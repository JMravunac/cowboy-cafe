using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new MenuItemSelectionControl();
            if (DataContext is Order order)
            {
                var btn = sender as Button; 
                order.Remove(btn.DataContext as IOrderItem);
                orderControl?.SwapScreen(screen);

            }
        }

        private void EditItemClick(object sender, SelectionChangedEventArgs e)
        {
            if (OrderList.SelectedItem == null)
            {
                return;
            }
            string itemString = OrderList.SelectedItem.ToString();

            if (itemString.Contains("Rustler's Ribs"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                RustlersRibs item = e.AddedItems[0] as RustlersRibs;
                if(DataContext is Order order)
                {
                    var screen = new RustlersRibsCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Pecos Pulled Pork"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                PecosPulledPork item = e.AddedItems[0] as PecosPulledPork;
                if (DataContext is Order order)
                {
                    var screen = new PecosPulledPordCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Angry Chicken"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                AngryChicken item = e.AddedItems[0] as AngryChicken;
                if (DataContext is Order order)
                {
                    var screen = new AngryChickenCustiomiztion();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Cowpoke Chili"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                CowpokeChili item = e.AddedItems[0] as CowpokeChili;
                if (DataContext is Order order)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Trail Burger"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                TrailBurger item = e.AddedItems[0] as TrailBurger;
                if (DataContext is Order order)
                {
                    var screen = new TrailBurgerCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Dakota Double Burger"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                DakotaDoubleBurger item = e.AddedItems[0] as DakotaDoubleBurger;
                if (DataContext is Order order)
                {
                    var screen = new DakotaDoubleBurgerCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Texas Triple Burger"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                TexasTripleBurger item = e.AddedItems[0] as TexasTripleBurger;
                if (DataContext is Order order)
                {
                    var screen = new TexasTripleBurgerCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Chili Cheese Fries"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                ChiliCheeseFries item = e.AddedItems[0] as ChiliCheeseFries;
                if (DataContext is Order order)
                {
                    var screen = new ChiliCheeseFriesCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Corn Dodgers"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                CornDodgers item = e.AddedItems[0] as CornDodgers;
                if (DataContext is Order order)
                {
                    var screen = new CornDodgersCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Pan de Campo"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                PanDeCampo item = e.AddedItems[0] as PanDeCampo;
                if (DataContext is Order order)
                {
                    var screen = new PanDeCampoCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Baked Beans"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                BakedBeans item = e.AddedItems[0] as BakedBeans;
                if (DataContext is Order order)
                {
                    var screen = new BakedBeansCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Jerked Soda"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                JerkedSoda item = e.AddedItems[0] as JerkedSoda;
                if (DataContext is Order order)
                {
                    var screen = new JerkedSodaCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Cowboy Coffee"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                CowboyCoffee item = e.AddedItems[0] as CowboyCoffee;
                if (DataContext is Order order)
                {
                    var screen = new CowboyCoffeeCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Tea"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                TexasTea item = e.AddedItems[0] as TexasTea;
                if (DataContext is Order order)
                {
                    var screen = new TexasTeaCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

            if (itemString.Contains("Water"))
            {
                var orderControl = this.FindAncestor<OrderControl>();
                Water item = e.AddedItems[0] as Water;
                if (DataContext is Order order)
                {
                    var screen = new WaterCustomization();
                    screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }

        }
    }
}
