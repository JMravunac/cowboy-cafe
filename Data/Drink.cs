/*
* Jack Mravunac
* Drink.cs 
* Base class for the drinks
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the list of special instructions for the drink
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        private bool ice = true;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public virtual bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
    }
}
