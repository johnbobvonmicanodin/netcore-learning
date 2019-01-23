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
    }
}
