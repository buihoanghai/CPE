using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CPE_vs1.BusinessLayer;

namespace CPE_vs1.DTO
{
    class LoanDetailDTO
    {
      public  int ID;
      public LoanDetail loanDetail;
      public TrackLoan[] trackloan=new TrackLoan[100]
          ;
    }
}
