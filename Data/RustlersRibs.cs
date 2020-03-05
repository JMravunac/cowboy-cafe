/*
* Jack Mravunac
* RustlersRibs.cs 
* Class representing the rustlers ribs entree
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's ribs entree
    /// </summary>
    public class RustlersRibs : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();


                return instructions;
            }
        }

        
        public override string ToString()
        {
            return "Rustler's Ribs";
        }

    }
}

