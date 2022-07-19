
using OnlineFoodOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaceptProject.Repositories
{
    public interface ICustomerRepository
    {

        //Method for Posting Customer Details
        public void AddCustomer(Customer customer);

        //Method for Adding Order Item
        public void AddOrderItem(int orderId);

        //Method for Placing Order
        public void PlaceOrder(Order order);

        //Method for Updating Order(Delete)
        public void ModifyOrder(Order order);

        //Method for Cancellation of Order by Order ID (In Admin)
        public void CancelOrder(int orderId);

        //  Method for Tracking Status of Order by OrderId
        public string TrackOrderStatus(int orderId);

        
    }
}
