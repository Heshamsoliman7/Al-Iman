using Al_Iman.Models;
using Al_Iman.Repositories.Interfaces;
using Al_Iman.Utilities;
using Al_Iman.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Iman.Services
{
    public interface ISupplierService
    {
        PagedResult<SupplierViewModel> GetAll(int pageNumber, int pageSize);
        IEnumerable<SupplierViewModel> GetAll();
        SupplierViewModel GetSupplierById(int SupplierId);
        void UpdateSupplier(SupplierViewModel Supplier);
        void InsertSupplier(SupplierViewModel Supplier);
        void DeleteSupplier(int id);
    }
}
