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
            //Would ask students about accessing internal bank properties here as you write the test
            Assert.AreEqual(bank.CustomerName, "John Walker");
        }

        [TestMethod]
        public void BankAccountHasMoney()
        {
            //Same as above
            Assert.AreEqual(bank.Balance, 50);
        }

        [TestMethod]
        public void DebitWorks()
        {
            bank.Debit(20);
            Assert.AreEqual(bank.Balance, 30);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Allowed user to remove negative money")]
        public void DebitDoesntAllowNegativeAmounts()
        {
            bank.Debit(-20);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Allowed user to debit more than their balance")]
        public void DebitDoesntAllowNegativeBalance()
        {
            bank.Debit(-60);
        }

        [TestMethod]
        public void CreditWorks()
        {
            bank.Credit(30);
            Assert.AreEqual(bank.Balance, 80);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Allowed user to add negative money")]
        public void CreditDoesntAllowNegativeAmounts()
        {
            bank.Credit(-20);
        }

        [TestMethod]
        public void ChangeTypeWorksWithLowerCase()
        {
            bank.ChangeType("savings");
            Assert.AreEqual(bank.Type, "savings");
        }

        [TestMethod]
        public void ChangeTypeWorksWithAnyCase()
        {
            bank.ChangeType("SaViNgS");
            Assert.AreEqual(bank.Type, "savings");
        }

        [TestMethod]
        public void ChangeTypeOnlyAllowsCheckingsOrSavings()
        {
            bank.ChangeType("broccoli");
            Assert.AreEqual(bank.Type, "checkings");
        }
    }
}
