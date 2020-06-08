/*
* Jack Mravunac
* CornDodgers.cs
* Class representing the corn dodgers side
*/

using System;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side, INotifyPropertyChanged
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

        /// <summary>
        /// The calories in the corn dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;

                    case Size.Medium:
                        return 685;

                    case Size.Small:
                        return 512;

                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// The price of the corn dodgers
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
                    return "Large Corn Dodgers";

                case Size.Medium:
                    return "Medium Corn Dodgers";

                case Size.Small:
                    return "Small Corn Dodgers";

                default:
                    throw new NotImplementedException("Unknown size");
            }
        }
    }
}