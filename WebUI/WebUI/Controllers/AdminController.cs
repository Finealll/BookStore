using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using BookStore.Entities.BaseObjects;
using BookStore.Entities.Products;

namespace WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public string AddBook(Book book)
        {
            _unitOfWork.GetRepository<Book>().Insert(book);
            _unitOfWork.SaveChanges();
            

            return "Добавлено!";
        }


    }
}
