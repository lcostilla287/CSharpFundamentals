﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    public class Transaction
    {
        //Making it private Readonly allows its information inside the class, but we can only set it at the time of construction
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;

            DateOfTransaction = DateTimeOffset.Now; //offset is current timezone changes whenever the timezone does
        }

        public DateTimeOffset DateOfTransaction { get; private set; }

        public decimal GetTransactionAmount()
        {
            //Accessing the object being held in the readonly _currency field getting into its properties.
            return _currency.Value;
        }

        public string GetTransactionType()
        {
            return _currency.Name;
        }
    }
}
