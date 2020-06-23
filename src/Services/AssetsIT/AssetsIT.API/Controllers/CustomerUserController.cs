using AssetsIT.API.Models;
using AssetsIT.API.Models.Response;
using AssetsIT.Domain.AggregatesModel.CustomerUserAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AssetsIT.API.Controllers
{
    [Route("api/v1/[controller]")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [ApiController]
    public class CustomerUserController : Controller
    {
        private readonly ICustomerUserRepository _customerUserRepository;

        public CustomerUserController(ICustomerUserRepository customerUserRepository) {
            _customerUserRepository = customerUserRepository;
        }

        [Route("user/{ownerId}")]
        [HttpGet]
        [ProducesResponseType(typeof(CustomerUserData), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerUserData>> GetCustomerUserByDni(string nroDni) {
            return await _customerUserRepository.GetCustomerUserByDni(nroDni);
        }

        [Route("chief-list")]
        [HttpGet]
        [ProducesResponseType(typeof(CustomerUserData), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<CustomerUserData>> GetListCustomerUserChief(string initialsNameBusiness) {
            return await _customerUserRepository.GetListCustomerUserChief(initialsNameBusiness);
        }

        [Route("termination")]
        [HttpGet]
        [ProducesResponseType(typeof(CustomerUserData), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<PaginatedItems<CustomerUserData>>> GetListCustomerUserCessation(string nroDni, string fullname, DateTime? startDate, DateTime? endDate, [FromQuery]int pageSize = 10, [FromQuery]int pageIndex = 0) {
            var user = await _customerUserRepository.GetCustomerUserByDni(nroDni);
            if (user == null) {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            CustomerCessationSearch search = new CustomerCessationSearch {
                ChiefCustomerId = user.CustomerId,
                FullName = fullname ?? "",
                StartDate = startDate == null ? null : startDate,
                EndtDate = endDate == null ? null : endDate
            };
            var response = await _customerUserRepository.GetListCustomerUserTermination(search);

            var totalItems = response.Count();

            var itemsOnPage = response
                .Skip(pageSize * pageIndex)
                .Take(pageSize)
                .ToList();

            return new PaginatedItems<CustomerUserData>(pageIndex, pageSize, totalItems, itemsOnPage);
        }

        [Route("termination")]
        [HttpPost]
        [ProducesResponseType(typeof(CustomerUserData), (int)HttpStatusCode.OK)]
        public ActionResult<bool> UpdateBulkListCustomersCessation([FromBody] CustomerCessationUpdateDTO[] customer) {
            if (customer == null) {
                return false;
            }
            var newCustomer = customer.Select(c => new CustomerCessationUpdate() { IdUser = c.IdUser, DateEndcontrat = c.DateEndcontrat });
            var customerList = new List<CustomerCessationUpdate>(newCustomer);
            return _customerUserRepository.UpdateBulkListCustomersCessation(customerList);
        }

        [Route("norenew")]
        [HttpGet]
        [ProducesResponseType(typeof(CustomerUserData), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<CustomerUserData>> GetListCustomerUserCessationNotRenew(string initialsNameBusiness) {
            return await _customerUserRepository.GetListCustomerUserTerminationNotRenew(initialsNameBusiness);
        }
    }
}