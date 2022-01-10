using Market.Models;
using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister operation = new CashRegister(500, Enums.Currency.AZN, Enums.PaymentType.Cash);

            operation.AddNewSale(80, Enums.Currency.AZN);
            operation.AddNewSale(100, Enums.Currency.TRY);
            operation.AddNewSale(100, Enums.Currency.USD);
            operation.AddNewSale(100, Enums.Currency.EUR);

            operation.RemoveSale(80, Enums.Currency.AZN);
            operation.RemoveSale(100, Enums.Currency.TRY);
            operation.RemoveSale(100, Enums.Currency.USD);
            operation.RemoveSale(100, Enums.Currency.EUR);

            operation.AddNewSale(55, Enums.Currency.AZN);

            Console.WriteLine(operation);
        }
    }
}
