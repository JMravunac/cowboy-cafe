using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Contains all relevant information for the current order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 0;

        //list of each item in the order
        private List<IOrderItem> items = new List<IOrderItem>();

        //Event handler
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Calculates the subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subTotal = 0.0;
                foreach(IOrderItem item in items)
                {
                    subTotal += item.Price;
                }
                return subTotal;
            }
        }

        //current order number
        public static uint OrderNumber { get { return lastOrderNumber++; } }

        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Invokes property changed event when the items, subtotal, or price changes
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void Remove(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
    }
}
