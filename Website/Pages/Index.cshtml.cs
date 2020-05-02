using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; }

        /// <summary>
        /// The categories
        /// </summary>
        [BindProperty]
        public string[] Category { get; set; }

        /// <summary>
        /// Current min calories
        /// </summary>
        [BindProperty]
        public uint? CalorieMin { get; set; }

        /// <summary>
        /// Current max calories
        /// </summary>
        [BindProperty]
        public uint? CalorieMax { get; set; }

        /// <summary>
        /// Current min price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Current max price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        public void OnGet()
        {
            Items = Menu.CompleteMenu;
            
        }

        public void OnPost()
        {
            Items = Menu.CompleteMenu;
            // Search menu items for the SearchTerms
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
           
            // Filter by item type  
            if (Category != null && Category.Length != 0)
            {                
                    Items = Items.Where(item => (item is Entree entree && Category.Contains("Entree")) || (item is Side side && Category.Contains("Side")) || (item is Drink drink && Category.Contains("Drink")));             
            }
            
            //filters items based on calories
            if(CalorieMin != null || CalorieMax != null)
            {
                if(CalorieMin == null)
                {
                    Items = Items.Where(item => item.Calories <= CalorieMax);
                }
                else if(CalorieMax == null)
                {
                    Items = Items.Where(item => item.Calories >= CalorieMin);
                }
                else
                {
                    Items = Items.Where(item => item.Calories <= CalorieMax && item.Calories >= CalorieMin);
                }
            }

            //filters items based on price
            if (PriceMin != null || PriceMax != null)
            {
                if (PriceMin == null)
                {
                    Items = Items.Where(item => item.Price <= PriceMax);
                }
                else if (PriceMax == null)
                {
                    Items = Items.Where(item => item.Price >= PriceMin);
                }
                else
                {
                    Items = Items.Where(item => item.Price <= PriceMax && item.Price >= PriceMin);
                }
            }
           

        }
    }
}
