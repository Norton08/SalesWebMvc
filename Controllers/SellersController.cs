using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list =_sellerService.FindAll();
            return View(list);
        }
    }
}
