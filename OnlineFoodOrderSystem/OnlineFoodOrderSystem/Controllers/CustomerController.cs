using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using NovaceptProject.Repositories;
using OnlineFoodOrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaceptProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private IAdminRepository _repository;
        public CustomerController(IAdminRepository repository)
        {
            _repository = repository;

        }


        //Add Menu Item
        [HttpPost]
        [Route("AddMenu")]
        public IActionResult AddMenuItem(Menu menu)
        {
            try
            {
                _repository.AddMenuItem(menu);
                return Ok("Item Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private IActionResult BadRequest(string message)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(string v)
        {
            throw new NotImplementedException();
        }

        //  Update Order Status
        [HttpPut]
        [Route("UpdateOrderStatus")]
        public IActionResult UpdateOrderStatus(Order order)
        {
            try
            {
                _repository.UpdateOrderStatus(order);
                return Ok("Order Modified");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        //Update Menu Item
        [HttpPut]
        [Route("UpdateMenuItem")]
        public IActionResult UpdateMenuItem(Menu menu)
        {
            try
            {
                _repository.UpdateMenuItem(menu);
                return Ok("Item Update");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete Menu By Menu Id
        [HttpDelete]
        [Route("DeleteMenu/{menuId}")]
        public IActionResult DeleteMenuItem(int menuId)
        {
            try
            {
                _repository.DeleteMenuItem(menuId);
                return Ok("Item Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
