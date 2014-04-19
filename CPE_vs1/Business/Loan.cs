using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPE_vs1.BusinessLayer;
namespace CPE_vs1.Business
{
    class Loan
    {
        public CPE cpe { get; set; }
        public LoanDetail loanDetail { get; set; }
        public PackageManagement package { get; set; }
        public Customer customer { get; set; }
        public Loan()
        {

        }
        public bool SaveLoanItem()
        {
            loanDetail.Insert(loanDetail);
            return true;
        }
        public bool DeleteLoanItem()
        {
            return true;
        }
        public bool NewCustomer()
        {
            return true;
        }
        public bool EditCustomer()
        {
            return true;
        }

    }
}
