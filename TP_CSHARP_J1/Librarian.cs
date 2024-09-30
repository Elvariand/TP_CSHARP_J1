using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public class Librarian
    {
        private string name {  get; set; }
        private string password { get; set; }

        public Librarian(string name = "LibrarianName", string password = "LibrarianPassword")
        {
            this.name = name;
            this.password = password;
        }
    }
}
