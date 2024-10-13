using Application_UseCase.Customer.Commands;
using Application_UseCase.DTOs;
using Domain.Interface.Repository;
using Infra_DataAccess.DbContexts;
using Infra_DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly MiddlewareDbContext dbContext;
    private readonly ICustomerRepo customerRepo;

    public CustomerController(MiddlewareDbContext dbContext,ICustomerRepo customerRepo)
    {
        this.dbContext = dbContext;
        this.customerRepo = customerRepo;
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody]CreateCustomerDto  customer)
    {
        // Add your logic here to create the customer
        var C = new CreateCustomer(dbContext,customerRepo);
        C.Execute(customer);
        dbContext.SaveChanges();
        return Ok();
    }
}
