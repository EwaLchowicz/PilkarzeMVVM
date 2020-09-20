using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PlayersMVVM
{
    public class PlayerViewModel:BaseViewModel
    {
        private Player mplayer;
        private string description;

        public string FirstName
        {
            get
            {
                return mplayer.FirstName;
            }
            set
            {
                mplayer.FirstName = value;
                onPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get
            {
                return mplayer.LastName;
            }
            set
            {
                mplayer.LastName = value;
                onPropertyChanged(nameof(LastName));
            }
        }

        public double Weight
        {
            get
            {
                return mplayer.Weight;
            }
            set
            {
                mplayer.Weight = value;
                onPropertyChanged(nameof(Weight));
            }
        }

        public int Age
        {
            get
            {
                return mplayer.Age;
            }
            set
            {
                mplayer.Age = value;
                onPropertyChanged(nameof(Age));
            }
        }

        public string Description
        {
            get { return this.ToString(); }
            set { description = value; onPropertyChanged(nameof(Description)); }
        }


        public override string ToString()
        {
            return mplayer.ToString();
        }

        public PlayerViewModel()
        {
            mplayer = new Player();
            description = this.ToString();
        }

        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="weight"></param>
        /// <param name="age"></param>
        /// <param name="pathToImage"></param>
        public PlayerViewModel(string firstName, string lastName, double weight, int age)
        {
            mplayer = new Player(firstName, lastName, weight, age);
            description = this.ToString();
        }
    }
}
