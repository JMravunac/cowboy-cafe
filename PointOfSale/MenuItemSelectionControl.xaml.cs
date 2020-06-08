using CowboyCafe.Data;
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;
using System.Windows;
using System.Windows.Controls;

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

            //Button handlers
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

        //Each method adds the corresponding item to the current order
        private void AddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            AngryChicken temp = new AngryChicken();
            var screen = new AngryChickenCustiomiztion();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowpokeChiliButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CowpokeChili temp = new CowpokeChili();
            var screen = new CowpokeChiliCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            RustlersRibs temp = new RustlersRibs();
            var screen = new RustlersRibsCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            PecosPulledPork temp = new PecosPulledPork();
            var screen = new PecosPulledPordCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            TrailBurger temp = new TrailBurger();
            var screen = new TrailBurgerCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            DakotaDoubleBurger temp = new DakotaDoubleBurger();
            var screen = new DakotaDoubleBurgerCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            TexasTripleBurger temp = new TexasTripleBurger();
            var screen = new TexasTripleBurgerCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            ChiliCheeseFries temp = new ChiliCheeseFries();
            var screen = new ChiliCheeseFriesCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCordDodgersButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CornDodgers temp = new CornDodgers();
            var screen = new CornDodgersCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            PanDeCampo temp = new PanDeCampo();
            var screen = new PanDeCampoCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            BakedBeans temp = new BakedBeans();
            var screen = new BakedBeansCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            JerkedSoda temp = new JerkedSoda();
            var screen = new JerkedSodaCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            TexasTea temp = new TexasTea();
            var screen = new TexasTeaCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CowboyCoffee temp = new CowboyCoffee();
            var screen = new CowboyCoffeeCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            Water temp = new Water();
            var screen = new WaterCustomization();
            screen.DataContext = temp;
            if (DataContext is Order order)
            {
                order.Add(temp);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}