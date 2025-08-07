using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 1 : Draw a real picture for class and object. Differentiate class and object in terms of diagram only.

Perform following tasks.

Task 1: Create a class

Task 2: Add few data members as private

Task 3: Add few methods as public to work on defined data members

Task 4: Create a Demo class with main method.

Task 5: Create at least two objects of a class defined in Task 1 into main method and call all methods using that object.

Task 6: Write comment for each important portion of code like data members’ declaration, methods, some important logic etc.

Task 7: Summarize above solution in your own few words to visualize the solution to the end user.
 
 
 */
namespace PJT
{
    class classVsObject
    {
        private string name;
        private int age;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void displayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    class Demo
    {
        static void Main()
        {
            classVsObject obj1 = new classVsObject();
            obj1.setName("Alice");
            obj1.setAge(30);
            obj1.displayInfo();
            classVsObject obj2 = new classVsObject();
            obj2.setName("Bob");
            obj2.setAge(25);
            obj2.displayInfo();
        }
    }
}