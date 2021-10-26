using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodaClasses
{
    public class DevTeamRepo
    {
        private List<DevTeam> _devTeam = new List<DevTeam>();
        public DeveloperRepo devRepo;

        public DevTeamRepo(DeveloperRepo d)
        {
            devRepo = d;
        }
        //CRUD

        //Create
        public void AddDeveloperToList(DevTeam team)
        {
            _devTeam.Add(team);
        }
        //Team
        public void AddDevelopersToTeam(string devTeamID, string companyID)

        {
            //Find team to add developers to

            GetDevTeamList();

            //Pick team to add developer to
            DevTeam newT = GetTeamByID(devTeamID);

            //Get Developer ID
            Developer newD = devRepo.GetMemberByID(companyID);

            //Add developer to team
            newT.Members.Add(newD);
        }
        //Read
        public List<DevTeam> GetDevTeamList()
        {
            return _devTeam;
        }

        //Update
        public bool UpdateExistingDevTeamList(string originalTeamList, DevTeam newTeamList)
        {
            //Find member list
            DevTeam oldList = GetTeamByID(originalTeamList);

            //Update member list
            if (oldList != null)
            {
                oldList.DevTeamName = newTeamList.DevTeamName;
                oldList.DevTeamID = newTeamList.DevTeamID;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveDevTeamFromList(string devTeamID)
        {
            DevTeam teamNum = GetTeamByID(devTeamID);

            if (teamNum == null)
            {
                return false;
            }

            int initialCount = _devTeam.Count;
            _devTeam.Remove(teamNum);
            if (initialCount > _devTeam.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper method
        private DevTeam GetTeamByID(string devTeamID)
        {
            foreach (DevTeam team in _devTeam)
            {
                if (team.DevTeamID.Equals(devTeamID))
                {
                    return team;
                }
            }

            return null;
        }
    }
}
