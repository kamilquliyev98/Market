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
        public int TotalSalesCount = 0;

        public CashRegister(double totalAmount, Currency currency = Currency.AZN, PaymentType paymentType = PaymentType.Cash)
        {
            TotalAmount = totalAmount;
            Currency = currency;
            PaymentType = paymentType;
        }

        public void AddNewSale(double price, Currency currency)
        {
            switch (Currency)
            {
                case Currency.AZN:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price;
                            break;
                        case Currency.TRY:
                            TotalAmount += price * 0.122564;
                            break;
                        case Currency.EUR:
                            TotalAmount += price * 1.9267;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 1.69898;
                            break;
                    }
                    break;
                case Currency.TRY:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 8.159;
                            break;
                        case Currency.TRY:
                            TotalAmount += price;
                            break;
                        case Currency.EUR:
                            TotalAmount += price * 15.72;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 13.85;
                            break;
                    }
                    break;
                case Currency.EUR:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 0.51888;
                            break;
                        case Currency.TRY:
                            TotalAmount += price * 0.0636090946;
                            break;
                        case Currency.EUR:
                            break;
                        case Currency.USD:
                            break;
                    }
                    break;
                case Currency.USD:
                    price *= 1.7;
                    break;
            }

            
            TotalSalesCount++;
        }

        public void RemoveSale(double price, Currency currency)
        {
            switch ((int)currency)
            {
                case (int)Currency.TRY:
                    price *= 0.12;
                    break;
                case (int)Currency.EUR:
                    price *= 1.92;
                    break;
                case (int)Currency.USD:
                    price *= 1.7;
                    break;
            }

            TotalAmount -= price;
            TotalSalesCount--;
        }

        public override string ToString()
        {
            return $"Satis sayi: {TotalSalesCount}\nKassadaki pul: {TotalAmount} AZN";
        }
    }
}
