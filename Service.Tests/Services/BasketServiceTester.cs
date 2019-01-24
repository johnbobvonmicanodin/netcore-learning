using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repositories.Interfaces;
using Repositories.Repositories;
using Services.Services;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Tests.Services
{
    [TestClass]
    public class BasketServiceTester
    {
        private IBasketRepository _basketRepository;
        private IBasketService _basketService;

        public BasketServiceTester()
        {
            _basketRepository = new BasketRepository(null);
            _basketService = new BasketService(_basketRepository);
        }

        [TestMethod]
        public void AddBasketWithoutProduct()
        {
            var mock = new Mock<IBasketRepository>();
            var newBasket = new Basket() { Product_choose = null };

            var service = new BasketService(mock.Object);
            var repBasket = service.AddItem(newBasket);

            Assert.IsTrue(repBasket == null);
        }

        [TestMethod]
        public void AddBasketWithoutUser()
        {
            var mock = new Mock<IBasketRepository>();
            var newBasket = new Basket() { BasketOwner = null };

            var service = new BasketService(mock.Object);
            var repBasket = service.AddItem(newBasket);

            Assert.IsTrue(repBasket == null);
        }
    }
}
