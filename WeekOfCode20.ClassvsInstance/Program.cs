using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.ClassvsInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
                
            }
        }
    }

    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
            else
                age = initialAge;

            // Add some more code to run some checks on initialAge
        }
        public void amIOld()
        {
            
            if (age < 13 && age >= 0)
            {
                Console.WriteLine("You are young.");
                return;
            }
            else if (age >= 13 &&age < 18) {
                Console.WriteLine("You are a teenager.");
                return;
            }
            else 
            {
                Console.WriteLine("You are old.");
                return;
            }
            // Do some computations in here and print out the correct statement to the console 
        }

        public void yearPasses()
        {
            age++;// Increment the age of the person in here
        }
    }
}
