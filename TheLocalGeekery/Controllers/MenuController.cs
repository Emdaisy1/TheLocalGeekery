using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheLocalGeekery.Models;

namespace TheLocalGeekery.Controllers
{
    public class MenuController : Controller
    {
        private MenuItemEntities menuDB = new MenuItemEntities();

        // GET: StoreManager
        public async Task<ActionResult> Index()
        {
            var menuItems = menuDB.MenuItems;
                //.Include(a => a.ItemIconUrl).Include(a => a.ItemName).Include(a => a.ItemDescription).Include(a => a.ItemPrice);
            return View(await menuItems.ToListAsync());
        }

        public ActionResult Details(int id)
        {
            var menuItem = new MenuItem { ItemId = id };
            return View(menuItem);
        }
    }
}