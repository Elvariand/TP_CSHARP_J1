using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class StudyBook : Book
    {
        public StudyBook(int bookId = 0, string author = "authorStudyBook", string name = "titleStudyBook", string edition = "editionStudyBook", double price = 45, int rackNo = 3, bool status = true) : base(bookId, author, name, edition, price, rackNo, status)
        { }
    }
}
