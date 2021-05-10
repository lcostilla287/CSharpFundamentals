using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_Interfaces
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            //same as _debt = _debt - payment.Value; can do with multiplication addition and division
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
        }

        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.01m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(315.52m));

            // our debt minus our epayment + $1
            decimal expectedDebt = 9000.01m - 316.52m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            //creating new instances of our ICurrency interface objects
            var dollar = new Dollar();
            var epay = new ElectronicPayment(243.71m);

            //"Injecting" them into Transaction class for that _currency field
            var firstTransaction = new Transaction(dollar);
            var secondTransation = new Transaction(epay);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransation.GetTransactionType());

            Console.WriteLine(secondTransation.GetTransactionAmount());
        }

        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Penny()),
                new Transaction(new Dime()),
                new Transaction(new Dollar())
            };

            foreach (var transation in list)
            {
                //Readability
                var type = transation.GetTransactionType();
                var amount = transation.GetTransactionAmount();

                Console.WriteLine($"{type} {amount} {transation.DateOfTransaction}");
                // Inline
                Console.WriteLine($"You paid ${transation.GetTransactionAmount()} on {transation.DateOfTransaction}");
                Console.WriteLine(); //for space


            }

        }
    }
}
