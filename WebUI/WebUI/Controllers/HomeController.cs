using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using BookStore.Entities.Products;
using Microsoft.AspNetCore.Authorization;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IUnitOfWork unitOfWork, ILogger<HomeController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        public IActionResult Index()
        {
            ViewBag.Detectives = _unitOfWork.GetRepository<Book>().GetAll()
                .Where(book => book.Jenre.Name == "Детектив")
                .OrderBy(u => u.Cost).Take(10);
            ViewBag.Romans = _unitOfWork.GetRepository<Book>().GetAll()
                .Where(book => book.Jenre.Name == "Роман")
                .OrderBy(u => u.Cost).Take(10);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
