using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSHARP_J1
{
    public abstract class Book
    {
        protected int bookId { get; set; }
        protected string author { get; set; }
        protected string name { get; set; }
        protected double price { get; set; }
        protected int rackNo { get; set; }
        protected bool status { get; set; }
        protected string edition { get; set; }
        protected DateTime dateOfPurchase { get; set; }
        
        public Book(int bookId = 0, string author = "author", string name = "title", string edition = "edition", double price = 0, int rackNo = 0, bool status = true, DateTime dateOfPurchase = new DateTime())
        {
            this.bookId = bookId == 0 ? new Random().Next(1, 10000000): bookId;
            this.price = price;
            this.status = status;
            this.author = author;
            this.name = name;
            this.rackNo = rackNo;
            this.edition = edition;
            this.dateOfPurchase = dateOfPurchase == new DateTime() ? DateTime.Now: dateOfPurchase;
        }



        public string DisplayBookDetails()
        {
            return this.name + " écrit par "
                + this.author + ", publié aux éditions "
                + this.edition + ", acheté le "
                + this.dateOfPurchase.ToShortDateString() + " au prix de "
                + this.price +"€, portant le numéro "
                + this.bookId + ", habituellement rangé dans le rack n° "
                + this.rackNo + ", est actuellement " + this.DisplayAvailability();
        }

        public string DisplayAvailability()
        {
            return this.status ? "Available" : "Issued";
        }

        public void UpdateStatus(bool status)
        {
            this.status = status;
        }

        public void UpdateStatus(string status)
        {
            status = status.ToLower().Trim();
            if (status == "available")
            {
                this.status = true;
            }
            else if (status == "issued")
            {
                this.status = false;
            } else { Console.WriteLine("There is a mistake in the availability status"); }
        }
    }
}
