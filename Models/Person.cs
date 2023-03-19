using System;
using hotelChallengeDio;

namespace hotelChallengeDio.Models
{
    public class Person
    {
       public Person() {}

       public Person (string name)
       {
            Name = name; 
       } 
       public Person (string name, string lastName)
       {
            Name = name;
            LastName = lastName;
       }

       public string Name { set; get; }
       public string LastName { set; get; }
       public string FullName => $"{Name} {LastName}".ToUpper(); 
    }
}