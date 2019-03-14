using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankAccountNS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Assert is handled by the ExpectedException attribute on the test method.
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }

}