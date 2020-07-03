using System;
using System.Runtime.Serialization;
using Interfaces;
namespace WellsFargoBankAccount
{
    public class WellsFargoBankAccountCreation : BankInterface
    {
        public override ILoanAccount CreateLoanAccount()
        {
            return new WellsFargoLoanAccount();
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            return new WellsFargoSavingsAccount();
        }
    }

    public class WellsFargoSavingsAccount : ISavingsAccount
    {
        public string SavingsAccountName { get; set; }
        public string SavingsAccountAddress { get; set; }

        public WellsFargoSavingsAccount()
        {
            SavingsAccountName = "Wells Fargo Savings Bank Account";
            SavingsAccountAddress = "Minneapolis, Minnesota";
        }
    }

    public class WellsFargoLoanAccount : ILoanAccount
    {
        public string LoanAccountName { get; set; }
        public string LoanAccountAddress { get; set; }

        public WellsFargoLoanAccount()
        {
            LoanAccountName = "Wells Fargo Loan Bank Account";
            LoanAccountAddress = "Eden Prairie, Minnesota";
        }
    }
}
