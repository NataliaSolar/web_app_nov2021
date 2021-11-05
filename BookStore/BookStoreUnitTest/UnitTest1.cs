using System;
using Xunit;
using BookStore.Models;

namespace BookStoreUnitTest
{
    public class BooksTest
    {
        [Fact]
        public void BookSellingPriceAssignmentSucceed()
        {
            double price = 20.50;
            Book newBook = new Book();

            newBook.SellingPrice = price;

            Assert.Equal(newBook.SellingPrice, price);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1234567.65, 1234567.65)]
        public void BookPriceAcceptsInput(double newPrice, double expected)
        {
            
            Book newBook = new Book();
            newBook.SellingPrice = newPrice;

            Assert.Equal(newBook.SellingPrice, expected);

        }
    }

    public class PersonTest
    {
        [Fact]
        public void PersonNameAssignmentSucceed()
        {
            string name = "Natalia";
            Person client = new Person();

            client.FirstName = name;

            Assert.Equal(client.FirstName, name);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("1223", "1223")]
        public void PersonAddressAcceptsInput(string newAddress, string expected)
        {

            Person client = new Person();
            client.Address = newAddress;

            Assert.Equal(client.Address, expected);

        }
    }

    public class PurchaseEventTest
    {
        [Fact]
        public void PurchaseEventDateAssignmentSucceed()
        {
            DateTime date = new DateTime(2021, 04, 30);
            PurchaseEvent newPurchase = new PurchaseEvent();
            newPurchase.PurchaseDate = date;

            Assert.Equal(newPurchase.PurchaseDate, date);
        }

        [Theory]
        [InlineData(null, null)]
        //[InlineData("1223", "1223")]
        public void PurchaseEventPurchaseDateAcceptsInput(DateTime date, DateTime expected)
        {

            PurchaseEvent newPurchase = new PurchaseEvent();

            newPurchase.PurchaseDate = date;

            Assert.Equal(newPurchase.PurchaseDate, expected);

        }
    }
}
