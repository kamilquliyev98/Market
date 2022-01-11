using Market.Models;
using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Currency: AZN
            Console.WriteLine("----------Currency: AZN - Operations----------");
            CashRegister operationAZN = new CashRegister(100, Enums.Currency.AZN, Enums.PaymentType.Cash);

            operationAZN.AddNewSale(12.6, Enums.Currency.AZN);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.AddNewSale(80.99, Enums.Currency.TRY);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.AddNewSale(27, Enums.Currency.USD);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.AddNewSale(10, Enums.Currency.EUR);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.RemoveSale(7.7, Enums.Currency.AZN);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.RemoveSale(5.8, Enums.Currency.TRY);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.RemoveSale(12, Enums.Currency.USD);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.RemoveSale(2.99, Enums.Currency.EUR);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");

            operationAZN.AddNewSale(123.45, Enums.Currency.USD);
            Console.WriteLine(operationAZN);
            Console.WriteLine("------------------------------");
            #endregion

            #region Currency: TRY
            Console.WriteLine("\n\n\n----------Currency: TRY - Operations----------");
            CashRegister operationTRY = new CashRegister(100, Enums.Currency.TRY, Enums.PaymentType.Cash);

            operationTRY.AddNewSale(3.9, Enums.Currency.AZN);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.AddNewSale(12, Enums.Currency.TRY);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.AddNewSale(3.65, Enums.Currency.USD);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.AddNewSale(2.99, Enums.Currency.EUR);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.RemoveSale(0.8, Enums.Currency.AZN);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.RemoveSale(0.55, Enums.Currency.TRY);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.RemoveSale(2.05, Enums.Currency.USD);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.RemoveSale(1.03, Enums.Currency.EUR);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");

            operationTRY.AddNewSale(20, Enums.Currency.USD);
            Console.WriteLine(operationTRY);
            Console.WriteLine("------------------------------");
            #endregion

            #region Currency: EUR
            Console.WriteLine("\n\n\n----------Currency: EUR - Operations----------");
            CashRegister operationEUR = new CashRegister(100, Enums.Currency.EUR, Enums.PaymentType.Card);

            operationEUR.AddNewSale(67.99, Enums.Currency.AZN);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.AddNewSale(7000.77, Enums.Currency.TRY);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.AddNewSale(29.99, Enums.Currency.USD);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.AddNewSale(13, Enums.Currency.EUR);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.RemoveSale(5.09, Enums.Currency.AZN);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.RemoveSale(2000.07, Enums.Currency.TRY);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.RemoveSale(2.5, Enums.Currency.USD);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.RemoveSale(1.03, Enums.Currency.EUR);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");

            operationEUR.AddNewSale(19, Enums.Currency.USD);
            Console.WriteLine(operationEUR);
            Console.WriteLine("------------------------------");
            #endregion

            #region Currency: USD
            Console.WriteLine("\n\n\n----------Currency: USD - Operations----------");
            CashRegister operationUSD = new CashRegister(100, Enums.Currency.USD, Enums.PaymentType.Card);

            operationUSD.AddNewSale(109.99, Enums.Currency.AZN);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.AddNewSale(1799.66, Enums.Currency.TRY);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.AddNewSale(12.81, Enums.Currency.USD);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.AddNewSale(19.33, Enums.Currency.EUR);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.RemoveSale(20.92, Enums.Currency.AZN);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.RemoveSale(766.99, Enums.Currency.TRY);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.RemoveSale(3.33, Enums.Currency.USD);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.RemoveSale(19.09, Enums.Currency.EUR);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");

            operationUSD.AddNewSale(20, Enums.Currency.USD);
            Console.WriteLine(operationUSD);
            Console.WriteLine("------------------------------");
            #endregion
        }
    }
}
