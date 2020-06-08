/*
* Jack Mravunac
* Drink.cs
* Base class for the drinks
*/

using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual bool SizeSmall { get; set; }
        public virtual bool SizeMedium { get; set; }
        public virtual bool SizeLarge { get; set; }

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
    }
}