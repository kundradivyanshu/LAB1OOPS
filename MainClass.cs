using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class MainClass
    {

        public static string personId;
        public static string firstName;
        public static string lastName;
        public static string favouriteColour;
        public static string isWorking;
        public static string age;
        public static object person1;
        public static object person2;
        public static object person3;
        public static object person4;

        public static void Main(string[] args) //Listing all the data provided in the data by taking 4 person objects
        {
            Person person1 = new Person
            {
                personId = 1,
                firstName = "Ian",
                lastName = "Brooks",
                favouriteColour = "Red",
                age = 30,
                isWorking = true,
            };



            Person person2 = new Person
            {
                personId = 2,
                firstName = "Gina",
                lastName = "Jmaes",
                favouriteColour = "Green",
                age = 18,
                isWorking = false,
            };


            Person person3 = new Person
            {
                personId = 3,
                firstName = "Mike",
                lastName = "Briscoe",
                favouriteColour = "Blue",
                age = 45,
                isWorking = true,
            };


            Person person4 = new Person
            {
                personId = 4,
                firstName = "Mary",
                lastName = "Beals",
                favouriteColour = "Yellow",
                age = 28,
                isWorking = true,
            };


            person2.DisplayPersonInfo(); // from program.cs

            person3.ToStringMethod(); // from program.cs

            person1.favouriteColour = "White";
            Console.WriteLine(person1.firstName + " " + person1.lastName + "'s favourite colour is " + person1.favouriteColour);

            person4.GetAgeInTenYears(); // from program.cs


            Relation relation1 = new Relation
            {
                RelationshipType = "sisterhood"
            };
            relation1.ShowRelationShip(person2, person4);

            Relation relation2 = new Relation
            {
                RelationshipType = "brotherhood"
            };
            relation2.ShowRelationShip(person1, person3);


            List<Person> List = new List<Person> 
            { person1, person2, person3, person4 };

            //Tried a lot but was not able to solve g part

            
            
        }
    }
}






        

       
       
        