using System;
using NUnit.Framework;
using TDDSample.Rentals;

namespace TDDSample
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var customer = new Customer("Taro");
            var movie = new Movie("スターウォーズVI",MovieRentalType.NewRelease);
            var rental = new Rental(movie, 3);
            customer.AddRental(rental);

            Assert.AreEqual("900 円",customer.Statement());
        }
        [Test]
        public void Test2()
        {
            var customer = new Customer("Taro");
            var movie = new Movie("スターウォーズVI",MovieRentalType.NewRelease);
            var rental = new Rental(movie, 5);
            var rental2 = new Rental(movie, 5);
            customer.AddRental(rental);
            customer.AddRental(rental2);
            Assert.AreEqual("3000 円",customer.Statement());
        }



        [Test]
        public void Test3()
        {
            var customer = new Customer("Taro");
            var movie = new Movie("クレヨンしんちゃん",MovieRentalType.Childrens);
            var rental = new Rental(movie, 4);
            customer.AddRental(rental);
            Assert.AreEqual("300 円",customer.Statement());

        }
        [Test]
        public void Test3_2()
        {
            var customer = new Customer("Taro");
            var movie = new Movie("クレヨンしんちゃん",MovieRentalType.Childrens);
            var rental = new Rental(movie, 2);
            customer.AddRental(rental);
            Assert.AreEqual("150 円",customer.Statement());

        }
        [Test]
        public void Test4()
        {
            var customer = new Customer("Taro");
            var movie = new Movie("シンゴジラ",MovieRentalType.Regular);
            var rental = new Rental(movie, 3);
            customer.AddRental(rental);

            Assert.AreEqual("400 円",customer.Statement());
        }
        [Test]
        public void Test4_2()
        {
            var customer = new Customer("Taro");
            var movie = new Movie("シンゴジラ",MovieRentalType.Regular);
            var rental = new Rental(movie, 2);
            customer.AddRental(rental);

            Assert.AreEqual("200 円",customer.Statement());
        }
    }
}