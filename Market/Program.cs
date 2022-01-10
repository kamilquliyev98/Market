using Market.Models;
using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister operation = new CashRegister(500, Enums.Currency.AZN, Enums.PaymentType.Cash);

            operation.AddNewSale(500, Enums.Currency.TRY);
            Console.WriteLine(operation);
        }
    }
}
