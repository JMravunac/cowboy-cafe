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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            AddAngryChickenButton.Click += AddAngryChickenButtonClick;
            AddCowpokeChiliButton.Click += AddCowpokeChiliButtonClick;
            AddRustlersRibsButton.Click += AddRustlersRibsButtonClick;
            AddPecosPulledPorkButton.Click += AddPecosPulledPorkButtonClick;
            AddTrailBurgerButton.Click += AddTrailBurgerButtonClick;
            AddDakotaDoubleBurgerButton.Click += AddDakotaDoubleBurgerButtonClick;
            AddTexasTripleBurgerButton.Click += AddTexasTripleBurgerButtonClick;
        }

        private void AddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }

        
        private void AddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        private void AddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        private void AddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        private void AddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        private void AddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }
    }
}
