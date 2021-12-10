using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain.Repositories;
using System;
using MyCompany.Areas.Admin.Service;
using MyCompany.Service;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public NewsItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public IActionResult Approve(Guid id)
        {
            var result = dataManager.NewsItems.GetNewsItemById(id);
            if (result != null)
            {
                result.IsApproved = true;
                result.IsChanged = true;
                dataManager.NewsItems.SaveNewsItem(result);
            }
            if (result.Author != null)
            {
                EmailService emailService = new EmailService();
                emailService.SendEmail(result.Author, "Результаты рецензии", "Ваша новость была одобрена");
            }
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }


        [HttpPost]
        public IActionResult Disapprove(Guid id)
        {
            var result = dataManager.NewsItems.GetNewsItemById(id);
            if (result != null)
            {
                result.IsApproved = false;
                result.IsChanged = true;
                dataManager.NewsItems.SaveNewsItem(result);
            }
            if (result.Author != null)
            {
                EmailService emailService = new EmailService();
                emailService.SendEmail(result.Author, "Результаты рецензии", "Ваша новость не была одобрена");
            }
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.NewsItems.DeleteNewsItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
