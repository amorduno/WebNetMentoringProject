using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebNetMentoringProject.Interfaces;
using WebNetMentoringProject.Models;
using WebNetMentoringProject.ViewModel;

namespace WebNetMentoringProject.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly DBShopContext _context;
        private readonly IPhotoService _photoService;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(DBShopContext context, IPhotoService photoService, ILogger<CategoriesController> logger)
        {
            _context = context;
            _photoService = photoService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Categories Index");

            return View(await _context.Categories.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            _logger.LogInformation("Categories Details");

            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public async Task<IActionResult> Create()
        {
            _logger.LogInformation("Categories Create");

            return View();
        }

        [Route("Categories/Create")]
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("Id,Name,Description,Picture")] CategoryViewModel categoryVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(categoryVM.Picture);
                var category = new Category
                {
                    Name = categoryVM.Name,
                    Description = categoryVM.Description,
                    Picture = result.Url.ToString(),
                };

                _context.Add(category);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Creating category...");
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }
            return View(categoryVM);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [Route("Categories/Edit")]
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(int id, [Bind("Id,Name,Description,Picture")] CategoryViewModel categoryVM)
        {
            if (id != categoryVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _photoService.AddPhotoAsync(categoryVM.Picture);
                    var category = new Category
                    {
                        Name = categoryVM.Name,
                        Description = categoryVM.Description,
                        Picture = result.Url.ToString(),
                    };

                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(categoryVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoryVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [Route("Categories/Delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'DBShopContext.Categories'  is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
