using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.Entities.BookAdditionals;
using BookStore.Entities.Products;

namespace WebUI.Controllers
{
    public class BookAdditionalController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookAdditionalController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Author(int id)
        {
            Author author = _unitOfWork.GetRepository<Author>().GetAll()
                .Where(el => el.ID == id).FirstOrDefault();
            ViewBag.Books = _unitOfWork.GetRepository<Book>().GetAll()
                .Where(book => book.AuthorId == id);
            return View(author);
        }
    }
}
