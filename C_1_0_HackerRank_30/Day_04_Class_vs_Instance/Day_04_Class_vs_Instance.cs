using System;

namespace Day_04_Class_vs_Instance
{
    class Person
    {
        public int age;
        public string message;

        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            this.message = "";  // !

            if (initialAge >= 0)
            {
                this.age = initialAge;
            }
            else
            {
                this.age = 0;
                this.message = "Age is not valid, setting age to 0.";
                Console.WriteLine(this.message);
            }
        }

        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (this.age >= 0)
            {
                if (this.age < 13)
                    this.message = "You are young.";
                else if (this.age >= 13 && this.age < 18)
                    this.message = "You are a teenager.";
                else
                    this.message = "You are old.";
                Console.WriteLine(this.message);
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            this.age += 1;
        }
    }

    class Program
    {
        static void Main(String[] args)
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
            Console.ReadKey();

        }
    }
    
}

