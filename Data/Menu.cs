using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> entrees = new List<IOrderItem>();

        private static List<IOrderItem> sides = new List<IOrderItem>();

        private static List<IOrderItem> drinks = new List<IOrderItem>();

        static Menu()
        {
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TrailBurger());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new TexasTripleBurger());

            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());

            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
        }

        /// <summary>
        /// Gets all the entrees in the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees { get { return entrees; } }

        /// <summary>
        /// Gets all the sides in the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Sides { get { return sides; } }

        /// <summary>
        /// Gets all the drinks in the menu
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks { get { return drinks; } }
    }
}
