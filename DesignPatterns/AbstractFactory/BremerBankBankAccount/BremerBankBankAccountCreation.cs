using System;
using Interfaces;

namespace BremerBankBankAccount
{
    public class BremerBankBankAccountCreation : BankInterface
    {
        public override ILoanAccount CreateLoanAccount()
        {
            return new BremerBankLoanBankAccount();
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            return new BremerBankSavingsBankAccount();
        }
    }

    public class BremerBankSavingsBankAccount : ISavingsAccount
    {
        public string SavingsAccountName { get; set; }
        public string SavingsAccountAddress { get; set; }

        public BremerBankSavingsBankAccount()
        {
            SavingsAccountName = "Bremer Bank Savings Bank Account";
            SavingsAccountAddress = "Plymouth, Minnesota";
        }
    }

    public class BremerBankLoanBankAccount : ILoanAccount
    {
        public string LoanAccountName { get; set; }
        public string LoanAccountAddress { get; set; }

        public BremerBankLoanBankAccount()
        {
            LoanAccountName = "Bremer Bank Loan Bank Account";
            LoanAccountAddress = "Edina, Minnesota";
        }
    }
}
