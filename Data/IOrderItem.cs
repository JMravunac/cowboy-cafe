using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface that allows the order to get price and special instructions of each item
    /// </summary>
    public interface IOrderItem
    {
        double Price { get; }

        uint Calories { get; }

        List<string> SpecialInstructions { get; }
    }
}