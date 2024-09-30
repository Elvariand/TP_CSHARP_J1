using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Faculty : MemberRecord
    {
        public Faculty(int memberId, string name = "facultyName", string address = "unknownButFaculty", string phoneNo = "0101010101", int maxBookLimit = 1500, int noBookIssued = 0, DateTime dateOfMembership = new DateTime()) : base(memberId, name, address, phoneNo, maxBookLimit, noBookIssued, dateOfMembership) { }
    }
}
