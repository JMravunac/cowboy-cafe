using CashRegister;
using CowboyCafe.Data;
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
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
            CreditButton.Click += CreditButtonClick;
            CashButton.Click += CashButtonClick;
            CancelButton.Click += CancelButtonClick;
        }

        private void CreditButtonClick(object sender, RoutedEventArgs e)
        {
            CardTerminal terminal = new CardTerminal();
            double tempTotal = double.Parse(total.Text.ToString(), System.Globalization.NumberStyles.Currency);
            ResultCode code = terminal.ProcessTransaction(tempTotal);
            bool card = true;

            if(code == ResultCode.Success)
            {
                PrintReceipt(card);
                var orderControl = this.FindAncestor<OrderControl>();
                var screen = new OrderControl();
                Order.OrderNumber++;
                orderControl.full.Child = screen;
            }
            else
            {
                ErrorCode.Text = code.ToString();
            }

        }

        private void CashButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new OrderControl();
            Order.OrderNumber++;
            orderControl.full.Child = screen;
        }

        private void PrintReceipt(bool card)
        {
            ReceiptPrinter printer = new ReceiptPrinter();
            DateTime currentTime = DateTime.Now;

            if(DataContext is Order order)
            {
                printer.Print("Order Number:\t" + Order.OrderNumber.ToString());
                printer.Print("\n" + currentTime.ToString() + "\n\n");

                foreach(IOrderItem item in order.Items)
                {
                    printer.Print(item.ToString() + "\t" + item.Price.ToString("C2") + "\n");
                    int temp = 0;
                    while(temp < item.SpecialInstructions.Count)
                    {
                        printer.Print("\t" + item.SpecialInstructions[temp].ToString() + "\n");
                        temp++;
                    }
                }

                printer.Print("\nSubtotal:\t" + order.Subtotal.ToString("C2"));
                printer.Print("\nTotal:\t\t" + order.Total.ToString("C2"));

                if (card)
                {
                    printer.Print("\nPayment Type:\tCredit\n\n\n");
                }
                else
                {
                    printer.Print("\nPayment Type:\tCash");
                }
            }
        }
    }
}
