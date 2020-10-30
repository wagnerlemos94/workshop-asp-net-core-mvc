using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Controllers.Services;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
    {
    public class SellersController : Controller
        {


        private readonly SellerService _sellerService;

        public SellersController(SellerService SellerService)
            {
            _sellerService = SellerService;
            }

        public IActionResult Index()
            {

            var list = _sellerService.FindAll();

            return View(list);
            }

        public IActionResult Create()
            {
            return View();
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
            {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
            }

        }
    }
