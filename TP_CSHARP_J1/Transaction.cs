using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_CSHARP_J1
{
    public class Transaction
    {
        private int transId {  get; set; }
        private int memberId { get; set; }
        private int bookId { get; set; }
        private DateTime dateOfIssue { get; set; }
        private DateTime dueDate { get; set; }

        public Transaction( int memberId, int bookId, DateTime dateOfIssue, int transId = 0)
        {
            this.transId = transId;
            this.memberId = memberId;
            this.bookId = bookId;
            this.dateOfIssue = dateOfIssue == new DateTime() ? DateTime.Now : dateOfIssue;
            this.dueDate = this.dateOfIssue.AddMonths(1);
        }

        //public void createTransaction(Transaction transaction)
        //{
        //    some code to add transaction in db
        //}
        //public void deleteTransaction(int transId)
        //{
        //    some code to delete transaction in db where dbTransId == transId
        //}
        //public Transaction retrieveTransaction(int transId)
        //{
        //    return Transaction in db where dbTransId == transId
        //}
    }
}
