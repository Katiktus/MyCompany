using Microsoft.AspNetCore.Mvc;
using System;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories;
using MyCompany.Service;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace MyCompany.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public bool IsExist(string Title)
        {
            if (dataManager.NewsItems.GetNewsItemByTitle(Title) != null) 
            {
                return true;
            }
            return false;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.NewsItems.GetNewsItemById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews");
            return View(dataManager.NewsItems.GetNewsItems());
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Edit(NewsItem model)
        {
            if(IsExist(model.Title))
            {
                ModelState.AddModelError("Title", "Такая новость уже существует");
            }
            else if (ModelState.IsValid)
            {
                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
