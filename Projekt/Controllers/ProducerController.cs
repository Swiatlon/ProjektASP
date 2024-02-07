using Microsoft.AspNetCore.Mvc;
using Projekt.Models.Producer;

namespace Projekt.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        // MAIN VIEW
        // GET: /Producer
        public IActionResult Index()
        {
            var producerList = _producerService.GetAllProducers();
            return View(producerList);
        }

        // DETAILS
        // GET: /Producer/Details/1
        public IActionResult Details(int id)
        {
            var product = _producerService.GetProducerById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // ADDING
        // GET: /Producer/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        // POST: /Producer/Create
        [HttpPost]
        public IActionResult Create(ProducerModel model)
        {
            if (ModelState.IsValid)
            {
                _producerService.AddProducer(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", model);
            }
        }

        // EDITING
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var producer = _producerService.GetProducerById(id);

            if (producer == null)
            {
                return NotFound();
            }

            return View("Edit", producer);
        }

        [HttpPost]
        public IActionResult Edit(ProducerModel model)
        {
            if (ModelState.IsValid)
            {
                _producerService.UpdateProducer(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit", model);
            }
        }

        // DELETING
        // GET: /Producer/Delete/1
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _producerService.GetProducerById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: /Producer/DeleteConfirmed/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _producerService.GetProducerById(id);

            if (product == null)
            {
                return NotFound();
            }

            _producerService.DeleteProducer(id);

            return RedirectToAction("Index");
        }
    }
}