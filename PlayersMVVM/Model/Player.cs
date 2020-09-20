using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersMVVM
{
    public class Player
    {
        string firstName;
        string lastName;
        double weight;
        int age;

        public string FirstName
        { get { return firstName; } set { firstName = value; } }
        public string LastName
        { get { return lastName; } set { lastName = value; } }
        public double Weight
        { get { return weight; } set { weight = value; } }
        public int Age
        { get { return age; } set { age = value; } }

        public Player()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            weight = 70;
            age = 15;
        }

        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// 
        public Player(string firstName, string lastName, double weight, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{firstName} {lastName}, wiek: {age}, waga: {weight}";
        }


    }
}
