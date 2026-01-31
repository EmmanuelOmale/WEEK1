using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week1TestClass.CSharpSyntax
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public Occupation Occupation { get; set; }
        public Car? Car { get; set; }


        public User(Gender gender, Occupation occupation, string? firstName = null, string? lastName = null, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Occupation = occupation;
        }

        public User() {}

                // Demonstrating LINQ
        public List<User> GetAdultUsers(List<User> users)
        {
            var adultUsers = from user in users
                             where user.Age >= 18
                             select user;

            // Demonstrating the check without LINQ
            // List<User> adultUsersWithoutLinq = new List<User>();
            // foreach (var user in users)
            // {
            //     if (user.Age >= 18)
            //     {
            //         adultUsersWithoutLinq.Add(user);
            //     }
            // }

            // return adultUsersWithoutLinq;

            return adultUsers.ToList();
        }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Occupation
    {
        Student,
        Engineer,
        Teacher,
        Doctor,
        Artist
    }
}