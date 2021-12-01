using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using BookStore.Entities.BaseObjects;
using BookStore.Entities.Products;
using BookStore.Entities.BookAdditionals;

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
        public IActionResult Book()
        {
            ViewBag.Jenres = _unitOfWork.GetRepository<Jenre>().GetAll();
            ViewBag.Authors = _unitOfWork.GetRepository<Author>().GetAll();
            ViewBag.Books = _unitOfWork.GetRepository<Book>().GetAll();
            return View();
        }

        [HttpPost]
        public string Book(Book book)
        {
            _unitOfWork.GetRepository<Book>().Insert(book);
            _unitOfWork.SaveChanges();


            return "Добавлено!";
        }


        [HttpGet]
        public IActionResult Jenre()
        {
            return View();
        }

        [HttpPost]
        public string Jenre(Jenre jenre)
        {
            _unitOfWork.GetRepository<Jenre>().Insert(jenre);
            _unitOfWork.SaveChanges();


            return "Добавлено!";
        }


        [HttpGet]
        public IActionResult Author()
        {
            ViewBag.Authors = _unitOfWork.GetRepository<Author>().GetAll();
            return View();
        }

        [HttpPost]
        public string Author(Author author)
        {
            _unitOfWork.GetRepository<Author>().Insert(author);
            _unitOfWork.SaveChanges();


            return "Добавлено!";
        }


    }
}
