﻿using Al_Iman.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Al_Iman.ViewModels
{
    public class SupplierViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public SupplierViewModel()
        {

        }
        public SupplierViewModel(Supplier model)
        {
            Id = model.Id;
            Company=model.Company;
            Phone=model.Phone;
            Email=model.Email;
            Address=model.Address;
        }

        public Supplier ConvertViewModel(SupplierViewModel model)
        {
            return new Supplier
            {
                Id=model.Id,
                Company = model.Company,
                Phone = model.Phone,
                Email = model.Email,
                Address = model.Address,
            };
        }

    }
}
