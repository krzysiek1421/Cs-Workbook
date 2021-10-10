using System;
using RandomNameGeneratorLibrary;

namespace P3_Lab_nr1
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public int Id;

        public override string ToString()
        {
            return $"Person ID: {Id} | Name: {FirstName} {LastName} | Age: {Age}";
        }
    }
    class Program
    {
        static int GenAge()
        {
            Random rnd = new Random();
            var age = rnd.Next(18, 101);
            return age;
        }
        static void SumAge(Person[] array)
        {
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].Age;
            }
            Console.WriteLine("The whole sum of their age is: " + sum);
        }

        static void Main(string[] args)
        {
            Person[] people = new Person[5];
            var personGenerator = new PersonNameGenerator();
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                people[i].FirstName = personGenerator.GenerateRandomFirstName();
                people[i].LastName = personGenerator.GenerateRandomLastName();
                people[i].Age = GenAge();
                people[i].Id = (i + 1);
            }

            foreach (var p in people)
            {
                Console.WriteLine(p.ToString());
            }
            SumAge(people);
        }
    }
}