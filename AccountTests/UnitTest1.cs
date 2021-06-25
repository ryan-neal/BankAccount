using Microsoft.VisualStudio.TestTools.UnitTesting;
using Account;
using System;

namespace AccountTests
{
    [TestClass]
    public class UnitTest1
    {
        BankAccount bank = new BankAccount("John Walker", 50);

        [TestMethod]
        public void BankAccountHasName()
        { 
            Assert.AreEqual(bank.CustomerName, "John Walker");
        }

        [TestMethod]
        public void BankAccountHasMoney()
        {
            
        }

        [TestMethod]
        public void DebitWorks()
        {
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Allowed user to remove negative money")]
        public void DebitDoesntAllowNegativeAmounts()
        {
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Allowed user to debit more than their balance")]
        public void DebitDoesntAllowNegativeBalance()
        {
            
        }

        [TestMethod]
        public void CreditWorks()
        {
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Allowed user to add negative money")]
        public void CreditDoesntAllowNegativeAmounts()
        {
            
        }

        [TestMethod]
        public void ChangeTypeWorksWithLowerCase()
        {
            
        }

        [TestMethod]
        public void ChangeTypeWorksWithAnyCase()
        {
            
        }

        [TestMethod]
        public void ChangeTypeOnlyAllowsCheckingsOrSavings()
        {
            
        }
    }
}
