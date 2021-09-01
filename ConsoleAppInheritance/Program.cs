using System;

namespace InheritanceDemo
{
    class Student
    {
        string firstname, identity;
        public Student(string firstname, string identity)
        {
            this.firstname = firstname;
            this.identity = identity;
        }
        ~Student()
        {

        }
    }
    class HostelStudent : Student
    {
        int roomno;
        public HostelStudent(string firstname, string identity, int roomno) : base(firstname, identity)
        {
            this.roomno = roomno;
            PrintDetails(firstname, identity, roomno);
        }

        public void PrintDetails(string firstname, string identity, int roomno)
        {
            Console.WriteLine("First Name: " + firstname);
            Console.WriteLine("Identity: " + identity);
            Console.WriteLine("Room No.: " + roomno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to World!");
            new HostelStudent("PQR", "ID002", 2);
            Console.ReadKey();
        }
    }
}