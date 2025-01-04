using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class Person
    {
        public string name;
        public string job;
        private int _age;

        public Person(string name1, string job1, int age)
        {
            name = name1;
            job = job1;
            _age = age;
        }
        public int Age 
        {
            get { return _age; }
            set { _age = value; }
        }
        public void Person_info() 
        {
            Console.WriteLine($"Hello my name is {name} \n I am {Age} years old");
        }
       
    }
    public class Students : Person
    {
        public int _id;
        public int _course;
        public Students(string name1, string job1, int age, int id, int course):base(name1, job1, age) 
        { 
            this._id = id;
            this._course = course;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Course
        {
            get { return _course; }
            set { _course = value; }
        }
        public void info()
        {
            Console.WriteLine($"Hello my name is {name} my ID {_id}");
        }
       /* public void Person_info()
        {
            Console.WriteLine("Salom salom man donishju");
        }*/
    }
    public class Subject
    {
        public string name;
        public List<string> arr = new List<string>();
        int count = 0;
        public Subject(string name)
        {
            this.name = name;
        }
        public void Add_stud(Person person)
        {
            arr.Add(person.name);
            count++;
            foreach(string i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n"+ count);
        }
    }
    
    class OOP
    {
        static void Main(string[] args)
        {
            Person a = new Person("Rahmatullo", "Student", 19);
            a.Age = 20;
            Console.WriteLine("----------------------------->"+a.Age);
            Person a1 = new Person("Ali", "Student", 18);
            Person a2 = new Person("Vali", "Student", 20);
            Console.WriteLine(a.name);
            a.Person_info();
            Console.Write("=================>>>\n");
            Subject dbms = new Subject("DBMS");
            dbms.Add_stud(a);
            dbms.Add_stud(a2);
            dbms.Add_stud(a1);
            Students rah = new Students("Rahmatullo", "Student", 19, 2300002, 1);
            rah.info();
            rah.Person_info();
            Console.WriteLine(a.Age);
            Console.ReadKey();
          
        }
    }
}