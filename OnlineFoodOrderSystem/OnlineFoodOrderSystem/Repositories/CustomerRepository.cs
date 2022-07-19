
using OnlineFoodOrderSystem;
using OnlineFoodOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaceptProject.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private MyContext context = null;
        public CustomerRepository(MyContext context)
        {
            this.context = context;
        }
        //Add Customer
        public void AddCustomer(Customer customer)
        {
            context.Add(customer);
            context.SaveChanges();
        }

        // Add Order Item
        

        //public void CalculateTotal(int noOfServing, int menuid)
        //{
        //    int totalAmount = ((int)(orderItem.NoOfServing * menu.Price));
        //}

        //Place Order
        public void PlaceOrder(Order order)
        {
            context.Add(order);
            context.SaveChanges();
        }

        //Update Order 
        public void ModifyOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }

        //Cancel Order By Order Id
        public void CancelOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(i => i.OrderId == orderId);
            context.Remove(order);
            context.SaveChanges();
        }

        //Track Order Status By Order Id
        

        

        public void AddOrderItem(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public string TrackOrderStatus(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
