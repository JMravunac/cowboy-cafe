/*
* Jack Mravunac
* JerkedSoda.cs 
* Class representing jerked soda
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The calories in the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
        }

        /// <summary>
        /// The price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        private SodaFlavor flavor;
        /// <summary>
        /// If the coffee has room for cream
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }


        /// <summary>
        /// Special instructions for the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
        public override string ToString()
        {
            string tempFlavor = "";
            switch (flavor)
            {
                case SodaFlavor.BirchBeer:
                    tempFlavor = "Birch Beer";
                    break;
                case SodaFlavor.CreamSoda:
                    tempFlavor = "Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    tempFlavor = "Orange Soda";
                    break;
                case SodaFlavor.RootBeer:
                    tempFlavor = "Root Beer";
                    break;
                case SodaFlavor.Sarsparilla:
                    tempFlavor = "Sarsparilla";
                    break;
            }
            switch (Size)
            {
                case Size.Large:
                    return $"Large {tempFlavor} Jerked Soda";
                case Size.Medium:
                    return $"Medium {tempFlavor} Jerked Soda";
                case Size.Small:
                    return $"Small {tempFlavor} Jerked Soda";
                default:
                    throw new NotImplementedException("Unknown size");

            }
        }
    }
}
