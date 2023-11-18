using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin1, pin2=1234, option, balance=10000, deposit,amount, a = 3, b;
            Console.WriteLine("\t$$$        Welcome to ABC ATM      $$$\n");
            start:
            Console.Write("Enter the four digit pin:");
            pin1 = int.Parse(Console.ReadLine());
            if(pin1 == pin2)
            {
                Console.WriteLine("Please select your options.");
                Console.WriteLine("\t 1 - Deposit.\n \t 2 - Withdraw.\n \t 3 - Balance.\n \t 4 - Change Pin.\n \t 5 - Exit.\n");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.WriteLine("Please Enter the amount to be deposited : ");
                        deposit = int.Parse(Console.ReadLine());
                        if (deposit <= 25000)
                        {
                            balance = balance + deposit;                        
                        Console.WriteLine("\t To show the account balance press 1.");
                        a= int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                Console.WriteLine($"\t Account balance : {balance}\n");
                            }
                            else
                            {
                                Console.WriteLine("\t Thanks for visiting our bank\n");
                            }
                        }
                break;
                        case 2:
                        Console.WriteLine("\tEnter the withdrwal amount :");
                        amount = int.Parse(Console.ReadLine());
                        if (amount <= balance)
                        {
                            balance = balance - amount;
                            Console.WriteLine($"\t After deduction balance : {balance}");
                        }
                        else
                        {
                            Console.WriteLine("\t Insuffient balance");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Account balance : {balance}");
                        break;
                    case 4:
                        Console.WriteLine("Enter a four digit number to change PIN");
                        pin2 =int.Parse(Console.ReadLine());
                        Console.WriteLine("\t Your PIN is updated sucessfully\n");
                        goto start;
                        break;
                    case 5:
                        Console.WriteLine("Thanks for visiting our bank");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid PIN");
                if ( a < 3)
                { 
                    a++;
                    goto start;
                }
            }
            Console.WriteLine("\t Press 1 to continue\n");
            b = int.Parse(Console.ReadLine());
            if (b == 1)
            
                goto start;
            

        }
    }
}
