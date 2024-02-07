using Microsoft.AspNetCore.Mvc;
using Projekt.Models.Addresses;
using Projekt.Models.Producer;

namespace Projekt.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;
        private readonly IAddressService _addressService;

        public ProducerController(IProducerService producerService, IAddressService addressService)
        {
            _producerService = producerService;
            _addressService = addressService;
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
            var producer = _producerService.GetProducerById(id);
            var address = _addressService.GetAddressById(producer.AddressId);
            ViewBag.Address = address;

            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // ADDING
        // GET: /Producer/Create
        [HttpGet]
        public IActionResult Create()
        {
            var addresses = _addressService.GetAllAddresses();
            ViewBag.Addresses = addresses;
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
                var addresses = _addressService.GetAllAddresses();
                ViewBag.Addresses = addresses;
                return View("Create", model);
            }
        }

        // EDITING
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var addresses = _addressService.GetAllAddresses();
            var producer = _producerService.GetProducerById(id);

            ViewBag.Addresses = addresses;

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

        [HttpGet]
        public IActionResult AddressDetails (int id)
        {
            var address = _addressService.GetAddressById(id);

            if (address == null)
            {
                return NotFound();
            }

            return View(address);
        }
    }
}