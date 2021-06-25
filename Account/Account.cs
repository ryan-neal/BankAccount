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
        /** The debit method throws an ArgumentOutOfRangeException
         * if the user withdraws more money than in their account
         * 
         * The method also throws an ArgumentOutOfRangeException if 
         * the user withdraws negative money
         * 
         * If no exception is thrown, the user's balance should 
         * subtract amount
         **/
        {
            
        }

        public void Credit(int amount)
        /** The credit method throws an ArgumentOutOfRangeException if 
         * the user adds negative money
         * 
         * If no exception is thrown, the user's balance should 
         * add amount
         **/
        {
            
        }

        public void ChangeType(string type)
        {
         /** The change type method changes this.Type as long as the user inputs 
          * checkings or savings
         **/
            
        }
    }
}
