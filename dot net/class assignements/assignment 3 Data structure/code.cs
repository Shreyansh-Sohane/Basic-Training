using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_assignment
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give number of student ");
            int number  =  Convert.ToInt32(Console.ReadLine()) ;

            List <Student> studentList = new List<Student> ();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Give student id");
                int id = Convert.ToInt32(Console.ReadLine() );
                Console.WriteLine("Give student name");
                string name = Console.ReadLine();

                Student student = new Student (id, name);
                studentList.Add (student);

            }


            foreach (Student student in studentList)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Id);
            }
        }
    }
}
