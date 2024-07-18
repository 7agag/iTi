using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace iTi 
{

    class Student //Task
    { 
        int id, age;
        string name;
        static Student()
        {
            Console.WriteLine("Hello\n");

        }
        public Student(int id, string name, int age = 18)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void getdata()
        {
            Console.WriteLine($"{id}----{name}----{age}");
        }
        public string checkAge() 
        {
            if (age >= 24) return $"{name} has been graduated";
            return $"{name} still student ";
        }
    }
    internal class Task1
    {
        //public static void Main(string[] args)
        //{
        //    Student std1 = new Student(20,"Mohamed");
        //    Student std2 = new Student(21,"Youssef",26);
        //    std1.getdata(); 
        //    std2.getdata();
        //    Console.WriteLine(std1.checkAge());
        //    Console.WriteLine(std2.checkAge());


        //}
    }

}