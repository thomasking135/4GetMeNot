using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GetMeNot
{
    public class Task
    {
        private string tasks;
        private string requirement;
        private string person;


        public string Tasks
        {
            get {return tasks;}
            set {tasks=value;}
        }

        public string Requirement
        {
            get { return requirement; }
            set { requirement = value; }
        }

        public string Person
        {
            get { return person; }
            set { person = value; }
        }
    }

}
