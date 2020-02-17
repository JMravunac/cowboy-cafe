/*
* Jack Mravunac
* CowboyCoffee.cs 
* Class representing cowboy coffee
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
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
    }
}
