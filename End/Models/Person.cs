using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End.Models
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }

        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Developer", Age = 24 });
            people.Add(new Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            people.Add(new Person { FirstName = "Brendan", LastName = "Enrick", Occupation = "Developer", Age = 30 });
            people.Add(new Person { FirstName = "Jane", LastName = "Doe", Occupation = "Developer", Age = 35 });
            people.Add(new Person { FirstName = "Beth", LastName = "Stevens", Occupation = "Accountant", Age = 40 });
            people.Add(new Person { FirstName = "Samuel", LastName = "Jackson", Occupation = "Developer", Age = 21 });
            people.Add(new Person { FirstName = "Johnny", LastName = "Depp", Occupation = "Chef", Age = 24 });
            people.Add(new Person { FirstName = "Greg", LastName = "Olsson", Occupation = "Manager", Age = 30 });
            people.Add(new Person { FirstName = "Chet", LastName = "Manly", Occupation = "Accountant", Age = 20 });
            people.Add(new Person { FirstName = "Randy", LastName = "Johnson", Occupation = "Chef", Age = 38 });

            return people;
        }

    }
}
