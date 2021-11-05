//Assignment 3, Natalia Solar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public string Edition { get; set; }
        public string Language { get; set; }
        public string Isbn { get; set; }
        public double SellingPrice { get; set; }
    }
}
