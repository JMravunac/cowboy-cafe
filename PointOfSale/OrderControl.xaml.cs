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
            // Button handlers
            ItemSelectionButton.Click += ItemSelectionButtonClick;
            CancelOrderButton.Click += CancelOrderButtonClick;
            CompleteOrderButton.Click += CompleteOrderButtonClick;
            DataContext = new Order();

        }

        private void ItemSelectionButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        //Creates a new order on press
        private void CancelOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        //Finishes the order on press
        private void CompleteOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

    }
}
