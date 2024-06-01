﻿using MVCWebApp.Models;
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

        //CRUD Operation Action Methods
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAll();
            ViewData["products"] = products;
            return View();
        }
        public IActionResult Details(int id)
        {
            var product = _productService.GetById(id);
            ViewData["SingleProduct"]=product;
            return View();
        }
        public IActionResult Remove(int id)
        {
            _productService.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id, Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
        }
    }
}
