using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Student : MemberRecord
    {
        public Student(int memberId, string name = "studentName", string address = "unknownButStudent", string phoneNo = "0606060606", int maxBookLimit = 5, int noBookIssued = 0, DateTime dateOfMembership = new DateTime()) : base(memberId, name, address, phoneNo, maxBookLimit, noBookIssued, dateOfMembership) { }
    }
}
