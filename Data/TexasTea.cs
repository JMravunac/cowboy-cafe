/*
* Jack Mravunac
* TexasTea.cs 
* Class representing Texas Tea
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink, INotifyPropertyChanged
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
        /// The calories in the tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown size");

                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown size");

                    }
                }

            }
        }

        /// <summary>
        /// The price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");

                }

            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool sweet = true;
        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { 
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ice = true;
        /// <summary>
        /// If the drink has ice
        /// </summary>
        public virtual bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Special instructions for the tea
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

        public override string ToString()
        {
            if(Sweet)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Sweet Tea";
                    case Size.Medium:
                        return "Medium Texas Sweet Tea";
                    case Size.Small:
                        return "Small Texas Sweet Tea";
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Plain Tea";
                    case Size.Medium:
                        return "Medium Texas Plain Tea";
                    case Size.Small:
                        return "Small Texas Plain Tea";
                    default:
                        throw new NotImplementedException("Unknown size");

                }
            }
            
        }
    }
}
