using System;
namespace Account
{
    public class BankAccount
    {
        public string CustomerName { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; }

        //constructor
        public BankAccount()
        {
        }

        //constructor2
        public BankAccount(string customerName, int balance)
        {
            this.CustomerName = customerName;
            this.Type = "checkings";
            this.Balance = balance;
        }

        public void Debit(int amount)
        {
            if (this.Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException("Not enough money in your account");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("You can't remove negative money");
            }
            this.Balance -= amount;
        }

        public void Credit(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("You can't add negative money");
            }
            this.Balance += amount;
        }

        public void ChangeType(string type)
        {
            if (type.ToLower().Equals("checkings") | type.ToLower().Equals("savings"))
            {
                this.Type = type.ToLower();
            }
        }
    }
}
