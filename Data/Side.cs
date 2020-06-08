﻿/*
* Nathan Bean
* Edited by Jack Mravunac
* CornDodgers.cs
* Base class for the sides
*/

using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual bool SizeSmall { get; set; }
        public virtual bool SizeMedium { get; set; }
        public virtual bool SizeLarge { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Returns an empty list of special instructions
        /// </summary>
        public List<string> SpecialInstructions => new List<string>();
    }
}