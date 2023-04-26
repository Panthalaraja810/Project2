using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Student
    {
        public String name;
        public int id;

        public Student(String name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void GetStudent()
        {
            Console.WriteLine(id + " " + name);
        }
    }

    public class Program
    {
        public static void aain(String[] args)
        {
            Student student = new Student("Raja", 1001);
            student.GetStudent();
        }
    }
}
