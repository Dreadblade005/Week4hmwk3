/// File Name: Homework 3 part 2
/// @author: Dakota Durst
/// Date:  September 19, 2020
///
/// Problem Statement: Take user input of item price (bewtween .25 and 1.00 in increments of 5) and calculate change based on user giving 1 dollar to buy item
///
/// 
/// Overall Plan:
/// 1) assign price to user input (type cast from string to int)
/// 2) assign other variables such as quarters, dimes, nickles, and change after each respective coin 
/// 3) subtract 100 by price to get change
/// 4) take result and divide by 25, edit change to amount of times 25 goes into change
/// 5) repeat for dimes and nickles
/// 6) print out amount of quarters, dimes, and nickles given to customer


using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments");
            int price = Convert.ToInt32(Console.ReadLine());
            int change = 100 - price;
            int num_quarter = 0;
            int num_dime = 0;
            int num_nickle = 0;
            int change_afterQ = 0;
            int change_afterD = 0;
            int change_afterN = 0;

            ///Processing
            
            num_quarter = change / 25;
            //calculate remaining change
            change_afterQ = change % 25;
            num_dime = change_afterQ / 10;
            change_afterD = change_afterQ % 10;
            num_nickle = change_afterD / 5;
            change_afterN = change_afterD % 5;

            ///output
            Console.WriteLine("You bought an item for " + price + " cents and gave me a dollar, so your change is:");
            Console.WriteLine(num_quarter + " quarters");
            Console.WriteLine(num_dime + " dimes and");
            Console.WriteLine(num_nickle + " nickles.");
        }
    }
}
