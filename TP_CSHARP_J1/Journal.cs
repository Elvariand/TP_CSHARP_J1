using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Journal : Book
    {
        public Journal(int bookId = 0, string author = "authorJournal", string name = "titleJournal", double price = 15.50, int rackNo = 1, bool status = true, string edition = "editionJournal") : base(bookId, author, name, price, rackNo, status, edition)
        { }
    }
}
