using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class BankDetails
    {
        private string bankName;
        private string accHolderName;
        private long accNumber;

        public void setBankName(string bankName)
        {
            this.bankName = bankName;
        }

        public string getBankName()
        {
            return this.bankName;
        }

        public void setAccHolderName(string accHolderName)
        {
            this.accHolderName = accHolderName;
        }

        public string getAccHolderName()
        {
            return this.accHolderName;
        }

        public void setAccNumber(long accNumber)
        {
            this.accNumber = accNumber;
        }

        public long getAccNumber()
        {
            return this.accNumber;
        }

    }
}
