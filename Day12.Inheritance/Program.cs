using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12.Inheritance
{
    public class Program
    {
         static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.calculate() + "\n");
        }
    }

     class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

     class Student : Person
    {
        private int[] testScores;
        private string name = string.Empty;
        private string lastname = string.Empty;
        int Id = 0;

        public Student()
        { }
        public Student(string name,string lastname,int ident,int [] test)
        {
            this.firstName = name;
            this.lastName = lastname;
            this.id = ident;
            Person persona= new Person(name, lastname, ident);
            testScores = test;
        }

        

        public string calculate()
        {
            string Status = string.Empty;
            int result = 0;
            for(int i=0;i<testScores.Length;i++)
            {
                result += testScores[i];
            }

            result = result / testScores.Length;

            if (result < 40)
                Status = "T";
            else if (result >= 40 && result < 55)
                Status = "D";
            else if (result >= 55 && result < 70)
                Status = "P";
            else if (result >= 70 && result < 80)
                Status = "A";
            else if (result >= 80 && result < 90)
                Status = "E";
            else if (result >= 90 && result <= 100)
                Status = "O";
                return Status;
        }

    }
}
