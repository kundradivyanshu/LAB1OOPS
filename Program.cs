using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class Person 

    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favouriteColour;
        public int age;
        public bool isWorking;

        public void DisplayPersonInfo() //	accepts the six person attributes and displays (Name= firstName + lastName)personId: Name’s favorite color is favoriteColour 

        {
            Console.WriteLine(personId + ":" + firstName + " " + lastName + "'s favourite colour is " + favouriteColour);
        }

        public void ChangeFavoriteColour() // changes the person’s favorite colour to white
        {
            favouriteColour = "White";
            Console.WriteLine(firstName + " " + lastName + "'s favourite color is" + favouriteColour);
        }

        public void GetAgeInTenYears() // get the person’s age after 10 years
        {
            age = +10;
            Console.WriteLine(firstName + " " + lastName + "'s age is" + age);
        }

        public void ToStringMethod() // displays all Person Object information as a list
        {
            Console.WriteLine(personId + "\n" + firstName + "\n" + " " + lastName + "\n" + favouriteColour + "\n" + age + "\n" + isWorking + "\n");

        }
    }
        public class Relation 
        {
            public string RelationshipType;  //	RelationshipType: values can be Sister, Brother, Mother or Father

        public void ShowRelationShip(Person person1, Person person2) // accepts two Person objects and displays the relationship between them
        {
                Console.WriteLine(person1.firstName + person1.lastName + "is" + RelationshipType + "of" + person2.firstName + person2.lastName);
            }

        }

}

