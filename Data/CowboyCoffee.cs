/*
* Jack Mravunac
* CowboyCoffee.cs 
* Class representing cowboy coffee
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The calories in the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
                

            }
        }

        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the coffee has room for cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        private bool decaf = false;
        /// <summary>
        /// If the coffee has room for cream
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// sets coffee to default to no ice
        /// </summary>
        private bool ice = false;
        
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (roomForCream) instructions.Add("Room for Cream");
                if (Ice) instructions.Add("Add Ice");

                return instructions;
            }
        }

        public override string ToString()
        {
            if(Decaf)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Decaf Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Decaf Cowboy Coffee";
                    case Size.Small:
                        return "Small Decaf Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
            switch (Size)
            {
                case Size.Large:
                    return "Large Cowboy Coffee";
                case Size.Medium:
                    return "Medium Cowboy Coffee";
                case Size.Small:
                    return "Small Cowboy Coffee";
                default:
                    throw new NotImplementedException("Unknown size");

            }
        }
    }
}
