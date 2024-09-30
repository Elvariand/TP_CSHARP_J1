using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Journal : Book
    {
        public Journal(int bookId = 0, string author = "authorJournal", string name = "titleJournal", string edition = "editionJournal", double price = 15.50, int rackNo = 1, bool status = true) : base(bookId, author, name, edition, price, rackNo, status)
        { }
    }
}
