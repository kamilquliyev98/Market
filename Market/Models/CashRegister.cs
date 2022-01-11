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

        public CashRegister(double totalAmount, Currency currency, PaymentType paymentType)
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
                            TotalAmount += price * 0.12;
                            break;
                        case Currency.EUR:
                            TotalAmount += price * 1.93;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 1.70;
                            break;
                    }
                    break;
                case Currency.TRY:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 8.13;
                            break;
                        case Currency.TRY:
                            TotalAmount += price;
                            break;
                        case Currency.EUR:
                            TotalAmount += price * 15.72;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 13.82;
                            break;
                    }
                    break;
                case Currency.EUR:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 0.52;
                            break;
                        case Currency.TRY:
                            TotalAmount += price * 0.064;
                            break;
                        case Currency.EUR:
                            TotalAmount += price;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 0.88;
                            break;
                    }
                    break;
                case Currency.USD:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 0.59;
                            break;
                        case Currency.TRY:
                            TotalAmount += price * 0.072;
                            break;
                        case Currency.EUR:
                            TotalAmount += price * 1.14;
                            break;
                        case Currency.USD:
                            TotalAmount += price;
                            break;
                    }
                    break;
            }

            TotalAmount = Math.Round(TotalAmount, 2);
            TotalSalesCount++;
        }

        public void RemoveSale(double price, Currency currency)
        {
            switch (Currency)
            {
                case Currency.AZN:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price;
                            break;
                        case Currency.TRY:
                            TotalAmount -= price * 0.12;
                            break;
                        case Currency.EUR:
                            TotalAmount -= price * 1.93;
                            break;
                        case Currency.USD:
                            TotalAmount -= price * 1.70;
                            break;
                    }
                    break;
                case Currency.TRY:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price * 8.13;
                            break;
                        case Currency.TRY:
                            TotalAmount -= price;
                            break;
                        case Currency.EUR:
                            TotalAmount -= price * 15.72;
                            break;
                        case Currency.USD:
                            TotalAmount -= price * 13.82;
                            break;
                    }
                    break;
                case Currency.EUR:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price * 0.52;
                            break;
                        case Currency.TRY:
                            TotalAmount -= price * 0.064;
                            break;
                        case Currency.EUR:
                            TotalAmount -= price;
                            break;
                        case Currency.USD:
                            TotalAmount -= price * 0.88;
                            break;
                    }
                    break;
                case Currency.USD:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price * 0.59;
                            break;
                        case Currency.TRY:
                            TotalAmount -= price * 0.072;
                            break;
                        case Currency.EUR:
                            TotalAmount -= price * 1.14;
                            break;
                        case Currency.USD:
                            TotalAmount -= price;
                            break;
                    }
                    break;
            }

            TotalAmount = Math.Round(TotalAmount, 2);
            TotalSalesCount--;
        }

        public override string ToString()
        {
            return $"Satis sayi: {TotalSalesCount}\nKassadaki pul: {TotalAmount} {Currency}";
        }
    }
}
