//Assignment 3, Natalia Solar
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class PurchaseEventController : Controller
    {
        // GET: PurchaseEventController
        public ActionResult Index()
        {


            PurchaseEvent firstPurchase = new PurchaseEvent();

            Person firstShopper = new Person();
            firstShopper.FirstName = "Natalia";
            firstShopper.LastName = "Solar";
            firstShopper.Address = "4300 15th Ave NE, Seattle, WA 98105";
            firstShopper.PhoneNumber = "(425) 123-1234";
            firstPurchase.Shopper = firstShopper;

            firstPurchase.PurchaseDate = DateTime.Now;

            Book purchasedBook = new Book();
            purchasedBook.BookName = "Under a White Sky: The Nature of the Future";
            purchasedBook.AuthorName = "Elizabeth Kolbert";
            purchasedBook.Publisher = "Crown";
            purchasedBook.Edition = "1";
            purchasedBook.Language = "English";
            purchasedBook.Isbn = "0593136276";
            purchasedBook.SellingPrice = 21.99;

            firstPurchase.PurchasedBook = purchasedBook;

            //List<Book> ListOfPurchasedBooks = new List<Book>();
            //ListOfPurchasedBooks.Add(purchasedBook);
            //firstPurchase.PurchasedBooks = ListOfPurchasedBooks;


            // public Person Shopper;
            //public DateTime PurchaseDate;
            //public List<Book> PurchasedBooks;

            return View(firstPurchase);
        }

        // GET: PurchaseEventController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PurchaseEventController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseEventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseEventController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseEventController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseEventController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseEventController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
