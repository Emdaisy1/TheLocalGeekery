using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TheLocalGeekery.Models
{
    public class MenuData : DropCreateDatabaseIfModelChanges<MenuItemEntities>
    {
        protected override void Seed(MenuItemEntities context)
        {
            new List<MenuItem>
            {
                new MenuItem { ItemId = 1, ItemType = "Dessert", ItemName = "Chocolate Frogs", ItemDescription = "NOT what they sound like! These are solid chocolate frogs, not chocolate-dipped frogs. Experience a Harry Potter style dessert - if yours doesn't hop away!", ItemIconUrl = "", ItemImageUrl = "", ItemPrice = 7.99M }
            }.ForEach(a => context.MenuItems.Add(a));
        }    
    }
}