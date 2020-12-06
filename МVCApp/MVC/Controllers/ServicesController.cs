using System;
using Microsoft.AspNetCore.Mvc;
using ManagerMVC.Domain;

namespace ManagerMVC.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}