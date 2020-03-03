using CowboyCafe.Data;
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddAngryChickenButton.Click += AddAngryChickenButtonClick;
            AddCowpokeChiliButton.Click += AddCowpokeChiliButtonClick;
            AddRustlersRibsButton.Click += AddRustlersRibsButtonClick;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButtonClick;
            AddTrailBurgerButton.Click += AddTrailBurgerButtonClick;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButtonClick;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButtonClick;

            AddChiliCheeseFriesButton.Click += AddChiliCheeseFriesButtonClick;
            AddCornDodgersButton.Click += AddCordDodgersButtonClick;
            AddPanDeCampoButton.Click += AddPanDeCampoButtonClick;
            AddBakedBeansButton.Click += AddBakedBeansButtonClick;

            AddJerkedSodaButton.Click += AddJerkedSodaButtonClick;
            AddTexasTeaButton.Click += AddTexasTeaButtonClick;
            AddCowboyCoffeeButton.Click += AddCowboyCoffeeButtonClick;
            AddWaterButton.Click += AddWaterButtonClick;
        }

        private void AddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            AngryChicken temp = new AngryChicken();
            if(DataContext is Order order)
            {
                order.Add(temp);
            }
        }


        private void AddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            CowpokeChili temp = new CowpokeChili();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            RustlersRibs temp = new RustlersRibs();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            PecosPulledPork temp = new PecosPulledPork();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            TrailBurger temp = new TrailBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger temp = new TexasTripleBurger();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries temp = new ChiliCheeseFries();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddCordDodgersButtonClick(object sender, RoutedEventArgs e)
        {
            CornDodgers temp = new CornDodgers();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            PanDeCampo temp = new PanDeCampo();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            BakedBeans temp = new BakedBeans();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            JerkedSoda temp = new JerkedSoda();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            TexasTea temp = new TexasTea();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            CowboyCoffee temp = new CowboyCoffee();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }

        private void AddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            Water temp = new Water();
            if (DataContext is Order order)
            {
                order.Add(temp);
            }
        }
    }
}
