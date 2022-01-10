using Market.Models;
using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister operation = new CashRegister(500, Enums.Currency.AZN, Enums.PaymentType.Cash);

            operation.AddNewSale(100, Enums.Currency.AZN);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.AddNewSale(100, Enums.Currency.TRY);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.AddNewSale(100, Enums.Currency.USD);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.AddNewSale(100, Enums.Currency.EUR);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.RemoveSale(100, Enums.Currency.AZN);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.RemoveSale(100, Enums.Currency.TRY);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.RemoveSale(100, Enums.Currency.USD);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.RemoveSale(100, Enums.Currency.EUR);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");

            operation.AddNewSale(10, Enums.Currency.USD);
            Console.WriteLine(operation);
            Console.WriteLine("------------------------------");
        }
    }
}
