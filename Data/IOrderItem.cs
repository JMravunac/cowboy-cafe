using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface that allows the order to get price and special instructions of each item
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        List<string> SpecialInstructions { get; }

    }
}
