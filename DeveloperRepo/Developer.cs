using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodaClasses

{
    //Developers have names + plus ID identify them without  mistakes
    // TM(DEV)Names+ID 

    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id{ get; set; }
        public string AccessP { get; set; }
       

    
        

        public  Developer () { }
        public Developer(string firstName, string lastName, string iD, string accessP)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = iD;
            AccessP = accessP;
        }

    }
}
