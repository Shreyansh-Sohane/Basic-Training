using System;
using System.Collections.Generic;

namespace Data_structure_demo
{
    internal class Program
    {
        class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public int marks { get; set; }

            public Student(int Id , string Name , int Marks) {
                id = Id;
                name = Name;
                marks = Marks;
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            Console.WriteLine($"\nSecond student is: {students[1].name}");


            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.id);
            }


            Console.WriteLine("Hashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
            }


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.name);


            Console.WriteLine("Queue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine(students_queue.Dequeue().name);


            Console.WriteLine("Linked List demo");
            LinkedList<Student> students_list = new LinkedList<Student>();

            students_list.AddFirst(first);
            students_list.AddLast(second);
            students_list.AddLast(third);

            foreach (Student student in students_list)
            {
                Console.WriteLine(student.id);
                Console.WriteLine(student.name);

                Console.WriteLine(student.marks);
            }




            Console.WriteLine("\nTuple Demo:");

            var studentTuple = Tuple.Create(first, second, third);

            Console.WriteLine($"Item1: {studentTuple.Item1.name}, Marks: {studentTuple.Item1.marks}");
            Console.WriteLine($"Item2: {studentTuple.Item2.name}, Marks: {studentTuple.Item2.marks}");
            Console.WriteLine($"Item3: {studentTuple.Item3.name}, Marks: {studentTuple.Item3.marks}");
        }
    }
}


