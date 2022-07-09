﻿using Microsoft.AspNetCore.Mvc;
using WebNetMentoringAPI.Interfaces;
using WebNetMentoringAPI.Models;

namespace WebNetMentoringAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategories()
        {
            var categories = _categoryRepository.GetCategories();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categories);
        }
    }
}