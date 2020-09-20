/// File Name: Homework 3
/// @author: Dakota Durst
/// Date:  September 19, 2020
///
/// Problem Statement: Take user input of total mortgage and mortgage payment and print out amount paid towards monthly interest and towards total mortgage
/// 
/// 
/// 
/// Overall Plan:
/// 1) assign mortgage and payment equal to user input (type cast string to double)
/// 2) assign other variables such as interest, princple and others needed for math
/// 3) get payment and subtract monthy interest (assume value is greater then zero)
/// 4) take result and output both monthly interst cost and amount paid towards mortgage
/// 4) set mortgage to new value and output new total mortgage

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string balance = total_balance.Text; //user outstanding balance
            double balance1 = Convert.ToDouble(balance); //convert string to double
            string payment = user_payment.Text; //user monthy payment
            double payment1 = Convert.ToDouble(payment); //convert string to double
            double flat_interest = .0639; //percentage of cost added to balance per year
            double month_interest = flat_interest / 12; //percent of cost increase of balance per month
            double interest_payment = month_interest * balance1; //amount of money added to balance per month
            double principle = payment1 - interest_payment; //money that will be subtracted to outstanding balance after interest_payment is paid off (assumes value is positive)
            Console.WriteLine(balance1);
            balance1 -= principle; //sets balance to new value based on money paid off
            Console.WriteLine(balance1);

            MessageBox.Show("Your payment of: " + payment1 + "$ has paid off: " + interest_payment + "$ of monthy interest and: " + principle + 
                "$ off your total mortgage leaving you with: " + balance1 + "$ remaining on your mortgage"); 
  





        }
    }
}
