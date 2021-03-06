﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//student name gursher singh, tanveer singh//
// student id 715837 716490//
namespace BankAccountNS
{
    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;
        private BankAccount()
        {
        }
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
            // ggggg
        }
        public string CustomerName
        {
            get { return m_customerName; }
        }
        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }
        private void FreezeAccount()
        {
            m_frozen = true;
        }
        private void UnfreezeAccount()
        {
            m_frozen = false;
        }
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.m_balance);
        }
    }
}

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            //Act
            account.Debit(debitAmount);
            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }
    }
}