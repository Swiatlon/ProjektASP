using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models.Producer;
using Projekt.Models.Products;

namespace Projekt.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProducerService _producerService;

        public ProductController(IProductService productService, IProducerService producerService)
        {
            _productService = productService;
            _producerService = producerService;
        }

        // MAIN VIEW
        // GET: /Product
        [AllowAnonymous]
        public IActionResult Index()
        {
            var productList = _productService.GetAllProducts();
            return View(productList);
        }

        // DETAILS
        // GET: /Product/Details/1
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            var producerName = _producerService.GetProducerNameById(product.ProducerId);
            ViewBag.ProducerName = producerName;

            return View(product);
        }

        // ADDING
        // GET: /Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            var producers = _producerService.GetAllProducers();
            ViewBag.Producers = producers;
            return View("Create");
        }

        // POST: /Product/Create
        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(model);
                return RedirectToAction("Index");
            }
            else
            {
                var producers = _producerService.GetAllProducers();
                ViewBag.Producers = producers;
                return View("Create", model);
            }
        }

        // EDITING
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productService.GetProductById(id);
            var producers = _producerService.GetAllProducers();
            ViewBag.Producers = producers;

            if (product == null)
            {
                return NotFound();
            }

            return View("Edit", product);

        }

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var producerName = _producerService.GetProducerNameById(model.ProducerId);
                ViewBag.ProducerName = producerName;

                _productService.UpdateProduct(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", model);
            }
        }

        // DELETING
        // GET: /Product/Delete/1
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: /Product/DeleteConfirmed/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            _productService.DeleteProduct(id);

            return RedirectToAction("Index");
        }
    }
}