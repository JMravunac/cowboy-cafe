﻿using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;

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
            Container.Child = new MenuItemSelectionControl();
        }

        //Creates a new order on press
        private void CancelOrderButtonClick(object sender, RoutedEventArgs e)
        {
            Order.OrderNumber++;
            this.DataContext = new Order();
        }

        //Finishes the order on press
        private void CompleteOrderButtonClick(object sender, RoutedEventArgs e)
        {
            full.Child = new TransactionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}