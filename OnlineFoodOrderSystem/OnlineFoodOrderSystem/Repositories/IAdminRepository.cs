
using OnlineFoodOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaceptProject.Repositories
{
    public interface IAdminRepository
    {
        // Method for Posting Menu Item
        public void AddMenuItem(Menu menu);

        // Method for Updating Menu Item
        public void UpdateMenuItem(Menu menu);

        // Method for Deleting Menu Item
        void DeleteMenuItem(int menuId);

        // Method for Updating Order by OrderId
        void UpdateOrderStatus(Order order);
    }
}
