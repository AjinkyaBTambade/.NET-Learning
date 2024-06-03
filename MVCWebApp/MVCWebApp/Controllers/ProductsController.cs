using MVCWebApp.Models;
using MVCWebApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace MVCWebApp.Controllers
{
    public class ProductsController : Controller
    {

        private IProductService _productService;
        public ProductsController(IProductService service)
        {
            _productService = service;
        }

        //CRUD Operation Action Method
       
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAll();
            ViewData["products"] = products;
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _productService.GetById(id);
            ViewData["SingleProduct"]=product;
            return View();
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            _productService.Remove(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            _productService.Insert(product);
            return RedirectToAction("ShowAll");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ShowAll()
        {
            var products = _productService.GetAll();
            return View(products);
        }
    }
}
