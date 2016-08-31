using apiCGE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiCGE.Controllers
{
    public class CategoryController : ApiController
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        [HttpGet]
        public List<CategoryVM> Category()
        {
            try
            {
                return db.Categories.Select(x => new CategoryVM
                {
                    ID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    Description = x.Description
                }).ToList();
            }
            catch
            {

                return null;
            }
        }

        [HttpPost]
        public string Add(CategoryVM vm)
        {
            try
            {
                db.Categories.Add(new Category
                {
                    CategoryName = vm.CategoryName,
                    Description = vm.Description
                });
                db.SaveChanges();
                return "Eklendi";
            }
            catch
            {
                return "İşlem Başarısız";
            }
        }
    }
}
