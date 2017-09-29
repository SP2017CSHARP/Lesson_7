using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End.Models;

namespace End
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Person.GenerateListOfPeople();


            ////find people over 30 

            //var pOver30 = people.Where(p => p.Age > 30);

            //foreach (Person p in pOver30)
            //{
            //    Console.WriteLine($"Name: {p.FirstName} {p.LastName} Age: {p.Age}" + Environment.NewLine);
            //}

            ////Select: 

            ////Get just first names 
            //var firstNames = people.Select(p => p.FirstName);



            ////get the first or default
            //Person firstPerson = people.FirstOrDefault();

            //Console.WriteLine(firstPerson.FirstName);

            ////First or default with criteria and check: 

            //Person mightBeNull = people.FirstOrDefault(x => x.Age > 50);

            //if (mightBeNull == null)
            //{
            //    Console.WriteLine("Nobody is older than 50");
            //}

            //else
            //{
            //    Console.WriteLine(mightBeNull.FirstName + " is " + mightBeNull.Age); 
            //}



            ////using count


            //int numberOfDevs = people.Count(x => x.Occupation == "Developer");

            //Console.WriteLine(numberOfDevs);



            ////To list

            //List <Person> myPeopleUnder30List = people.Where(x => x.Age <= 30).ToList();

            ////To Array

            //Person[] arrayOfManagers = people.Where(x => x.Occupation == "Manager").ToArray();




            /*Starting with the Person class and the collection you used in this lesson, 
             * create a program that prints the name of each developer older than a specified age. 
             * Prompt the user with the Console.ReadLine() method to determine the 
             * age to use for filtering the collection.*/


            Console.WriteLine("What age of developer would you like to find?");

            int devAge = int.Parse(Console.ReadLine());

           
            var returnedDevs = people.Where(x => x.Age == devAge && x.Occupation == "Developer");


            if (returnedDevs.Any())
            {
                foreach (Person p in returnedDevs)
                {
                    Console.WriteLine($"Name: {p.FirstName} {p.LastName} \n Age: {p.Age}" + Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine($"No developers that are {devAge}");
            }


            //Create a program that lets users sort through a collection of movies.

            //You should have a class called movies that contains properties for: 
            //Category (comedy, drama, horror, etc) 
            //Release Date
            //Lead Actor
            //Lead Actress 
            //A list of your films 
            //A method that initializes a list with 50 movies
            //A method that lists all movies 

            //A film constructor
            
            //If the user searches for a film that isnt in your library, you should ask them to make a 
            //new film request that asks for the input values of that film then creates a new one of that type and 
            //Adds it to the list 
            





        }

    }
}
