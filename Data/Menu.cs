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
        /// Searches the menu for matching items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of menu items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            // Return all items if there are no search terms
            if (terms == null) return CompleteMenu;
            // return each item in the database containing the terms substring
            foreach (IOrderItem item in CompleteMenu)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given items to those with the given categories
        /// </summary>
        /// <param name="items"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return items;

            var results = new List<IOrderItem>();

            foreach(IOrderItem item in items)
            {
                if(item is Entree entree)
                {
                    if (category.Contains("Entree")) results.Add(item);
                }

                if (item is Side side)
                {
                    if (category.Contains("Side")) results.Add(item);
                }

                if (item is Drink drink)
                {
                    if (category.Contains("Drink")) results.Add(item);
                }

            }

            return results;
            
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? calorieMin, uint? calorieMax)
        {
            if (calorieMin == null && calorieMax == null) return items;

            var results = new List<IOrderItem>();

            if (calorieMin == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= calorieMax) results.Add(item);
                }
                return results;
            }

            if (calorieMax == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories >= calorieMin) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if (item.Calories >= calorieMin && item.Calories <= calorieMax) results.Add(item);
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? priceMin, double? priceMax)
        {
            if (priceMin == null && priceMax == null) return items;

            var results = new List<IOrderItem>();

            if(priceMin == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price <= priceMax) results.Add(item);
                }
                return results;
            }

            if (priceMax == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= priceMin) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if (item.Price >= priceMin && item.Price <= priceMax) results.Add(item);
            }

            return results;
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
