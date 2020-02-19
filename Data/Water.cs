﻿/*
* Jack Mravunac
* Water.cs 
* Class representing water
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// The calories in the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Small:
                        return 0;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Small:
                        return 0.12;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the water has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// Special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

    }
}