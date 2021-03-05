using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
            
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{ i }", i);
                    Console.WriteLine(result.TransactionAmount);
                }
                catch (Exception ex)
                {
                    switch (ex.Message)
                    {
                        case "You can't buy zero items":
                            Console.WriteLine($"Payment skipped for payment with {i} items");
                            break;
                        case "This is an odd format":
                            Console.WriteLine("Formatting issue");
                            break;
                        case "One of the identified items was in an invalid format.":
                            Console.WriteLine("Formatting issue");
                            break;
                        case "object reference not set to an instance of an object":
                            Console.WriteLine($"Null value for item {i}");
                            break;
                        default:
                            Console.WriteLine($"Payment skipped for payment with {i} items");
                            break;
                    }
                   
                }
            }
            Console.ReadLine();
        }
    }
}
