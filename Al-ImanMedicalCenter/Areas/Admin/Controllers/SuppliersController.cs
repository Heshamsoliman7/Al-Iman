using Al_Iman.Models;
using Al_Iman.Services;
using Al_Iman.Utilities;
using Al_Iman.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Al_ImanMedicalCenter.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SuppliersController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        public IActionResult Index(int pageNumber = 1, int pageSize = 10)
        {
            return View(_supplierService.GetAll(pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var viewModel = _supplierService.GetSupplierById(id);
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(SupplierViewModel vm)
        {
            _supplierService.UpdateSupplier(vm);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SupplierViewModel vm)
        {
            _supplierService.InsertSupplier(vm);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _supplierService.DeleteSupplier(id);
            return RedirectToAction("Index");
        }
    }
}
