using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebMeni.Controllers;
using WebMeni.Models;
using WebMeni.Services;
using Xunit;

namespace WebMeniUnitTest
{
    public class BeerTesting
    {
        private readonly BeerController _controller;
        private readonly IBeerService _service;
        public BeerTesting()
        {
            _service = new BeerService();
            _controller = new BeerController(_service);
        }
        [Fact]
        public void GetOk()
        {
            var result = _controller.Get();
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetQuantity()
        {
            var result = (OkObjectResult)_controller.Get();
            var beer = Assert.IsType<List<Beers>>(result.Value);
            Assert.True(beer.Count > 0);
        }
    }
}