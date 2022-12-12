using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork13
{
    internal class BankTransaction
    {
        private DateTime current_time;
        private double sum;
        public BankTransaction(double sum)
        {
            this.sum = sum;
            current_time = DateTime.Now;
        }
        public DateTime CurrentTime { get { return current_time; } }
        public double Sum { get { return sum; } }
    }
}
