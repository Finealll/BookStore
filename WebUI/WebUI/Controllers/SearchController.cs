using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using BookStore.Entities.BaseObjects;
using BookStore.Entities.BookAdditionals;
using System.Linq;

namespace WebUI.Controllers
{
    public class SearchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private int pageSize = 50;
        public SearchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string text, int page)
        {
            ViewBag.SearchText = text;
            var products = _unitOfWork.GetRepository<ProductObject>().GetAll()
                .Where(t => t.Name.Contains(text))
                .Skip((page - 1) * pageSize).Take(pageSize);

            return View(products);
        }
    }
}
