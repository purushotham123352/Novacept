using Microsoft.EntityFrameworkCore;
using OnlineFoodOrderSystem;
using OnlineFoodOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaceptProject.Repositories
{
    public class AdminRepository:IAdminRepository
    {
        private MyContext context = null;
        public AdminRepository(MyContext context)
        {
            this.context = context;
        }

        //Add Menu Item
        public void AddMenuItem(Menu menu)
        {
            context.Add(menu);
            //TotalAmount(int noOfServings, decimal price)
            context.SaveChanges();
        }
        //Update Menu Item by Menu Id
        public void UpdateMenuItem(Menu menu)
        {
            context.Update(menu);
            context.SaveChanges();
        }
        // Delete Item Menu by Menu Id

        public void DeleteMenuItem(int menuId)
        {
            Menu menu = context.Menu.SingleOrDefault(i => i.Menuid == menuId);
            context.Remove(menu);
            context.SaveChanges();
        }

        // Get Menu Item  Details by Menu Id        
        public List<Menu> GetMenu(int menuId)
        {
            List<Menu> menu = context.Menu.FromSqlRaw("sp_GetMenuByMenuId {0}", menuId).ToList();
            return menu;
        }

        // Updating Order Status
        public void UpdateOrderStatus(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }

        
    }
}
