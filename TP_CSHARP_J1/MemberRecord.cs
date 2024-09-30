using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_CSHARP_J1
{
    public abstract class MemberRecord
    {
        protected int memberId { get; set; }
        protected string type { get; set; }
        protected DateTime dateOfMembership { get; set; }
        protected int noBookIssued { get; set; }
        protected int maxBookLimit { get; set; }
        protected string name { get; set; }
        protected string address { get; set; }
        protected string phoneNo { get; set; }

        public MemberRecord(int memberId = 0, string name = "memberName", string address = "unknown", string phoneNo = "0102030405", int maxBookLimit = 5, int noBookIssued = 0, DateTime dateOfMembership = new DateTime())
        {
            this.memberId = memberId == 0 ? new Random().Next(1, 10000000) : memberId;
            this.name= name;
            this.address = address;
            this.phoneNo = phoneNo;
            this.maxBookLimit = maxBookLimit;
            this.noBookIssued = noBookIssued;
            this.dateOfMembership = dateOfMembership == new DateTime() ? DateTime.Now : dateOfMembership;
            this.type = this.GetType() == typeof(Student) ? "student": "faculty";
        }


        //public MemberRecord RetrieveMember(int memberId)
        //{
        //    return MemberRecord en BDD où bddMemberId == memberId
        //}
        //public MemberRecord RetrieveMember(string name)
        //{
        //    return MemberRecord en BDD où bddname == name
        //}

        public void increaseBookIssued()
        {
            if (this.noBookIssued < this.maxBookLimit)
            {
                this.noBookIssued++;
            } else
            {
                Console.WriteLine("Maximum number of book issued reached");
            }
        }

        public void decreaseBookIssued()
        {
            if (this.noBookIssued > 0)
            {
                this.noBookIssued--;
            }
            else
            {
                Console.WriteLine("No book issued to " + this.name);
            }
        }

        //public void payBill(int billId)
        //{
        //    SoapSchemaMember code to pay the bill in db where dbBillId == billId
        //}
    }
}
