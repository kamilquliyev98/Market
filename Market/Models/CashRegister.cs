using Market.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Models
{
    class CashRegister
    {
        public double TotalAmount { get; set; }
        public Currency Currency { get; set; }
        public PaymentType PaymentType { get; set; }
        public static int TotalSalesCount = 0;

        public CashRegister(double totalAmount, Currency currency = Currency.AZN, PaymentType paymentType = PaymentType.Cash)
        {
            TotalAmount = totalAmount;
            Currency = currency;
            PaymentType = paymentType;
        }

        public void AddNewSale(double amount, Currency currency)
        {
            TotalSalesCount++;

            switch ((int)currency)
            {
                case (int)Currency.TRY:
                    amount *= 0.12;
                    break;
                case (int)Currency.EUR:
                    amount *= 1.92;
                    break;
                case (int)Currency.USD:
                    amount *= 1.7;
                    break;
            }

            TotalAmount += amount;
        }

        public void RemoveSale(double amount, Currency currency)
        {
            TotalSalesCount--;

            switch ((int)currency)
            {
                case (int)Currency.TRY:
                    amount *= 0.12;
                    break;
                case (int)Currency.EUR:
                    amount *= 1.92;
                    break;
                case (int)Currency.USD:
                    amount *= 1.7;
                    break;
            }

            TotalAmount -= amount;
        }

        public override string ToString()
        {
            return $"Satis sayi: {TotalSalesCount}\nKassadaki pul: {TotalAmount} AZN";
        }
    }
}
