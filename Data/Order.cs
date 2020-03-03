using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 0;

        private List<IOrderItem> items = new List<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;

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

        public static uint OrderNumber { get { return lastOrderNumber++; } }

        public IEnumerable<IOrderItem> Items => items.ToArray();

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
