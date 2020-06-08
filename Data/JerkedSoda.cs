/*
* Jack Mravunac
* JerkedSoda.cs
* Class representing jerked soda
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeLarge"));
            }
        }

        /// <summary>
        /// checks if size is small and sets size to small
        /// </summary>
        public override bool SizeSmall
        {
            get { return Size == Size.Small; }
            set
            {
                Size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// checks if size is medium and sets size to medium
        /// </summary>
        public override bool SizeMedium
        {
            get { return Size == Size.Medium; }
            set
            {
                Size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// checks if size is large and sets size to large
        /// </summary>
        public override bool SizeLarge
        {
            get { return Size == Size.Large; }
            set
            {
                Size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

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

        private SodaFlavor flavor = SodaFlavor.BirchBeer;

        /// <summary>
        /// getter/setter for soda flavor
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return this.flavor; }
            set
            {
                this.flavor = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorBirchBeer"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorCreamSoda"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorOrangeSoda"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorSarsparilla"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorRootBeer"));
            }
        }

        /// <summary>
        /// checks if flavor is birch beer and sets flavor to birch beer
        /// </summary>
        public bool FlavorBirchBeer
        {
            get { return Flavor == SodaFlavor.BirchBeer; }
            set
            {
                Flavor = SodaFlavor.BirchBeer;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// checks if flavor is birch beer and sets flavor to birch beer
        /// </summary>
        public bool FlavorCreamSoda
        {
            get { return Flavor == SodaFlavor.CreamSoda; }
            set
            {
                Flavor = SodaFlavor.CreamSoda;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// checks if flavor is orange soda and sets flavor to orange soda
        /// </summary>
        public bool FlavorOrangeSoda
        {
            get { return Flavor == SodaFlavor.OrangeSoda; }
            set
            {
                Flavor = SodaFlavor.OrangeSoda;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// checks if flavor is sarsparilla and sets flavor to sarsparilla
        /// </summary>
        public bool FlavorSarsparilla
        {
            get { return Flavor == SodaFlavor.Sarsparilla; }
            set
            {
                Flavor = SodaFlavor.Sarsparilla;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// checks if flavor is root beer and sets flavor to root beer
        /// </summary>
        public bool FlavorRootBeer
        {
            get { return Flavor == SodaFlavor.RootBeer; }
            set
            {
                Flavor = SodaFlavor.RootBeer;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
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