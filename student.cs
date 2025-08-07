using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    class Students
    {
        private string enrollment;
        private string name;

        public string Enrollment
        {
            get { return enrollment; }
            set { enrollment = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Test2
    {
        static void Main()
        {
            Students obj = new Students();
            obj.Enrollment = "12345";
            obj.Name = "Yashvi";
            Console.WriteLine("Enrollment: " + obj.Enrollment);
            Console.WriteLine("Name: " + obj.Name);
        }
    }
    
}
