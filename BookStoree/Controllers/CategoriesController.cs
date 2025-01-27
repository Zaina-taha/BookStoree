﻿using BookStoree.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStoree.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context;

        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
    }
}
