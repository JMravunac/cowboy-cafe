using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        private static List<IOrderItem> entrees = new List<IOrderItem>();

        private static List<IOrderItem> sides = new List<IOrderItem>();

        private static List<IOrderItem> drinks = new List<IOrderItem>();

        private static List<IOrderItem> completeMenu = new List<IOrderItem>();

        /// <summary>
        /// adds all menu items to their respective categories
        /// </summary>
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

            completeMenu.Add(new AngryChicken());
            completeMenu.Add(new CowpokeChili());
            completeMenu.Add(new PecosPulledPork());
            completeMenu.Add(new RustlersRibs());
            completeMenu.Add(new TrailBurger());
            completeMenu.Add(new DakotaDoubleBurger());
            completeMenu.Add(new TexasTripleBurger());

            completeMenu.Add(new BakedBeans());
            completeMenu.Add(new ChiliCheeseFries());
            completeMenu.Add(new CornDodgers());
            completeMenu.Add(new PanDeCampo());

            completeMenu.Add(new CowboyCoffee());
            completeMenu.Add(new JerkedSoda());
            completeMenu.Add(new TexasTea());
            completeMenu.Add(new Water());
        }

        /// <summary>
        /// Gets the possible menu item types
        /// </summary>
        public static string[] ItemType
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
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

        /// <summary>
        /// Gets all the items in the menu
        /// </summary>
        public static IEnumerable<IOrderItem> CompleteMenu { get { return completeMenu; } }
    }
}
