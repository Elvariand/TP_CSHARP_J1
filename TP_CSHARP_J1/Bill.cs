using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Bill
    {
        private string billNo {  get; set; }
        private DateTime date {  get; set; }
        private int memberId { get; set; }
        private double amount { get; set; }

        public Bill(int memberId, double amount)
        {
            this.date = DateTime.Now;
            this.billNo = date.ToString("yyyymmdd") + "-" + new Random().Next(1, 10000000) as string;
            this.memberId = memberId;
            this.amount = amount;
        }

    public override string ToString()
    {
            return "receipt n° " + this.billNo + " amounting to " + this.amount + "€ adressed to member n° " + this.memberId + ".";
    }

    // CRUD Bill
    }
}
