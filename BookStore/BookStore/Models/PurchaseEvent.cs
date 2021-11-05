//Assignment 3, Natalia Solar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class PurchaseEvent
    {
        public int PurchaseEventId { get; set; }
        public Person Shopper { get; set; }
        public DateTime PurchaseDate { get; set; }
        //public List<Book> PurchasedBooks;
        public Book PurchasedBook { get; set; }

    }
}
