using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodaClasses
{
    //Create POCO
    public class DeveloperRepo
    {
        private List<Developer> _listOfDevelopers = new List<Developer>();

        //CRUD

        //Create

        public void AddDeveloper(Developer developer)
        {
            _listOfDevelopers.Add(developer);
        }

        //Read

        public List<Developer> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        // Update 

        public bool UpdateExistingDeveloperList(string originalDeveloperList, Developer newDeveloperlist)
        {
            // find the list
            Developer oldList = GetMemberByID(originalDeveloperList);

            //Update 
            if (oldList != null)
            {
                oldList.FirstName = newDeveloperlist.FirstName;
                oldList.LastName = newDeveloperlist.LastName;
                oldList.Id = newDeveloperlist.Id;
                oldList.AccessP = newDeveloperlist.AccessP;
                return true;
            }
            else
            {
                return false;
            }

            //Delete

        }
        public bool RemoveDeveloperFromList(string id)
        {
            Developer member = GetMemberByID(id);

            if (member == null)
            {
                return false;
            }

            int initialCount = _listOfDevelopers.Count;
            _listOfDevelopers.Remove(member);
            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Helper method
        public Developer GetMemberByID(string companyID)
        {
            foreach (Developer member in _listOfDevelopers)
            {
                if (member.Id.Equals(companyID))
                {
                    return member;
                }
            }

            return null;
        }
    }
}
