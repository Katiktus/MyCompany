using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories;
using MyCompany.Service;

namespace MyCompany.Controllers
{
    public class MessageController : Controller
    {
        private readonly DataManager dataManager;

        public MessageController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Message() : dataManager.Messages.GetMessageById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Message model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Messages.SaveMessages(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
