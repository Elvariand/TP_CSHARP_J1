using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Magazine : Book
    {
        public Magazine(int bookId = 0, string author = "authorMagazine", string name = "titleMagazine", double price = 5.30, int rackNo = 2, bool status = true, string edition = "editionMagazine") : base(bookId, author, name, price, rackNo, status, edition)
        { }
    }
}
