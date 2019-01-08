using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository blogrepository;
        private ICategoryRepository categorirepository;
        public BlogController(IBlogRepository blogrepo, ICategoryRepository categorirepo)
        {
            blogrepository = blogrepo;
            categorirepository = categorirepo;
        }
        public IActionResult Index(int? id,string q)
        {
            var query = blogrepository.GetAll().
                        Where(x => x.isApproved == true);
                if (id!=null)
            {
                query = query.
                        Where(i => i.CategorId == id);
            }
            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(i => EF.Functions.Like(i.Title, "%" + q + "%") 
                || EF.Functions.Like(i.Body, "%" + q + "%") 
                || EF.Functions.Like(i.Description, "%" + q + "%"));
            }
            return View(query.
                        OrderByDescending(i => i.Date));
        }
        public IActionResult List()
        {
            //return View(blogrepository.GetAll().Where(x=>x.isApproved==true));
            return View(blogrepository.GetAll());
        }

        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(categorirepository.GetAll(), "Id", "Name");
            if (id==null)
            {
                return View(new Blog());
            }
            else
            {
                return View(blogrepository.GetById((int)id));
            }
        }
        [HttpPost]
        public IActionResult AddOrUpdate(Blog entity)
        {
            if (ModelState.IsValid)
            {
                blogrepository.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} Kayit edildi";
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(categorirepository.GetAll(), "Id", "Name");
            return View(entity);
        }
        [HttpGet]
        public IActionResult Delete (int id)
        {
            return View(blogrepository.GetById(id));
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            blogrepository.DeleteBlog(Id);
            TempData["message"] = $"{Id} Kayit silindi";
            return RedirectToAction("List");

        }
        public IActionResult Details (int id)
        {
            return View(blogrepository.GetById(id));
        }
    }
}