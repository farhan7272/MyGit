using Interfaces;
using System;
using WellsFargoBankAccount;
using BremerBankBankAccount;

namespace BankAccountProvider
{
    public class BankAccountProvider
    {
        public BankAccountProvider()
        {

        }

        public ISavingsAccount GetSavingsAccount(string bankaccountname)
        {
           
            switch (bankaccountname)
            {
                case "wsave":
                    WellsFargoBankAccountCreation wells = new WellsFargoBankAccountCreation();
                    return wells.CreateSavingsAccount();
                case "bsave":
                    BremerBankBankAccountCreation bremer = new BremerBankBankAccountCreation();
                    return bremer.CreateSavingsAccount();
                    
                default:
                    return null;
                    
            }
           
        }

        public ILoanAccount GetLoanAccount(string bankaccountname)
        {
            switch (bankaccountname)
            {
                case "wloan":
                    WellsFargoBankAccountCreation wells = new WellsFargoBankAccountCreation();
                    return wells.CreateLoanAccount();
                case "bloan":
                    BremerBankBankAccountCreation bremer = new BremerBankBankAccountCreation();
                    return bremer.CreateLoanAccount();
                default:
                    return null;

            }
        } 
    }
}
