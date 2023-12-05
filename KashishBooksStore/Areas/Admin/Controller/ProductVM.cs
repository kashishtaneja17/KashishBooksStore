using KashishBooks.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace KashishBooksStore.Areas.Admin.Controllers
{
    internal class ProductVM
    {
        public ProductVM()
        {
        }

        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}