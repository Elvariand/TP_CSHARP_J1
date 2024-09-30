using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Magazine : Book
    {
        public Magazine(int bookId = 0, string author = "authorMagazine", string name = "titleMagazine", string edition = "editionMagazine", double price = 5.30, int rackNo = 2, bool status = true) : base(bookId, author, name, edition, price, rackNo, status)
        { }
    }
}
