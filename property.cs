
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    class Student {
        private string firstname;
        //private string lastname;
        //1st way
        public string getFirstname()
        {
            return firstname;
        }
        public void setFirstname(string fstname)
        {
            this.firstname = fstname;
        }//
        //2nd way
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
    }
    class Test
    {
        static void Main() { 
            Student obj=new Student();
            //1st
            obj.setFirstname("John with methods used");
            Console.WriteLine(obj.getFirstname());
            //2nd 
            obj.FirstName = "Doe with property used";
            Console.WriteLine(obj.FirstName);
        }
    }
    internal class property
    {
        
    }
}
