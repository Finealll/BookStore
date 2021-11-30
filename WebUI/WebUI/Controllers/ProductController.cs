using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arch.EntityFrameworkCore.UnitOfWork;
using BookStore.Entities.Products;
using BookStore.Entities.BaseObjects;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var product = _unitOfWork.GetRepository<ProductObject>().GetAll().Where(product => !product.isArchived);
            return View(product);
        }

        [HttpGet]
        public IActionResult Book(int id)
        {
            var book = _unitOfWork.GetRepository<Book>().GetAll().Where(book => book.ID == id && book.isArchived == false);
            return View(book);
        }
    }
}
