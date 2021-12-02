using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BookStore.Entities.Products;

namespace WebUI.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private int pageSize = 50;

        public CatalogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BookCatalog(int page = 1)
        {
            var books = _unitOfWork.GetRepository<Book>().GetAll()
                .Skip((page - 1) * pageSize).Take(pageSize);

            return View(books);
        }
    }
}
