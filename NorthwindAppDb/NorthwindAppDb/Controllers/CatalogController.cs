﻿using Microsoft.AspNetCore.Mvc;
using NorthwindAppDb.Models;
using NorthwindAppDb.Repository;

namespace NorthwindAppDb.Controllers
{
    public class CatalogController : Controller
    {

        private readonly ICatagoryRepository _categoryRepository;

        public CatalogController(ICatagoryRepository catagoryRepository)
        {
            _categoryRepository = catagoryRepository;
        }
        public  async Task<IActionResult> GetAllCategories()
        {
           List<Category> categories = await  _categoryRepository.GetCategory();
            return View(categories);
        }


    }
}
