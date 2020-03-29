/*
* Jack Mravunac
* BakedBeans.cs 
* Class representing the baked beans side
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class BakedBeans : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;

        /// <summary>
        /// Size of the bread
        /// </summary>
        public override Size Size
        {
            get { return this.size; }
            set
            {
                this.size = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        
        /// <summary>
        /// The calories in the beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        /// <summary>
        /// The price of the beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Baked Beans";
                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Small:
                    return "Small Baked Beans";
                default:
                    throw new NotImplementedException("Unknown size");

            }
        }
    }
}