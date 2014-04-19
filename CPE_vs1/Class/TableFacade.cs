using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPE_vs1.BusinessLayer;
namespace CPE_vs1
{
    static class TableFacade
    {
        public static CPE cpe = new CPE();
        public static Customer customer = new Customer();
        public static Loan loan = new Loan();
        public static LoanDetail loanDetail = new LoanDetail();
        public static LocationDetail location = new LocationDetail();
        public static PackageManagement package = new PackageManagement();
        public static Site site = new Site();
        public static Staff staff = new Staff();
    }
}
