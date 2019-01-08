using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository catrepository;
        public CategoryController(ICategoryRepository catrepo)
        {
            catrepository = catrepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(catrepository.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category entity)
        {
            if (ModelState.IsValid)
            {
                catrepository.AddCategory(entity);
                return RedirectToAction("List");
            }
            return View(entity);
        }
        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            if (id == null)
            {
                return View(new Category());
            }
            else
            {
                return View(catrepository.GetById((int)id));
            }
        }
        [HttpPost]
        public IActionResult AddOrUpdate(Category entity)
        {
            if (ModelState.IsValid)
            {
                catrepository.SaveCategory(entity);
                TempData["message"] = $"{entity.Name} Kayit edildi";
                return RedirectToAction("List");
            }
            return View(entity);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(catrepository.GetById(id));
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            catrepository.DeleteCategory(Id);
            TempData["message"] = $"{Id} Kayit silindi";
            return RedirectToAction("List");

        }
    }
}