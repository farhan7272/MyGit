using System;

namespace Interfaces
{
    public abstract class BankInterface
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    public interface ILoanAccount
    {
        string LoanAccountName { get; set; }
        string LoanAccountAddress { get; set; }
    }

    public interface ISavingsAccount
    {
        string SavingsAccountName { get; set; }
        string SavingsAccountAddress { get; set; }
    }
}
