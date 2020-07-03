using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountProvider;
using Interfaces;

namespace BankAccountAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var ans = string.Empty;
            do
            {
                Console.WriteLine("Please Enter the Bank account name");
                var bankname = Console.ReadLine();
                FetchBankAccountDetails(bankname);
                Console.WriteLine("Do you want to continue(y/n)");
                ans = Console.ReadLine();
            } while (ans == "y");


        }

        private static void FetchBankAccountDetails(string bankname)
        {
            BankAccountProvider.BankAccountProvider bankAccountProvider = new BankAccountProvider.BankAccountProvider();
            if (bankname.ToLower().Trim().Contains("loan"))
            {
                ILoanAccount loanAccount = bankAccountProvider.GetLoanAccount(bankname);
                if (loanAccount == null)
                {
                    Console.WriteLine("Account not recognized");
                }
                else
                {
                    Console.WriteLine(loanAccount.LoanAccountName);
                    Console.WriteLine(loanAccount.LoanAccountAddress);
                }
            }
            else
            {
                ISavingsAccount savingsAccount = bankAccountProvider.GetSavingsAccount(bankname);
                if (savingsAccount != null)
                {
                    Console.WriteLine(savingsAccount.SavingsAccountName);
                    Console.WriteLine(savingsAccount.SavingsAccountAddress);
                }
                else
                {
                    Console.WriteLine("Account not recognized");
                }
            }
        }
    }
}
