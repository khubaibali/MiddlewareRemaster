using Application_UseCase.DTOs;
using Domain;
using Domain.Interface.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_UseCase.Customer.Commands;

public sealed class CreateCustomer
{
    private readonly ICustomerRepo _customerRepo;
    private readonly DbContext _dbContext;

    public CreateCustomer(DbContext dbcontext,ICustomerRepo customerRepo)
    {
        _customerRepo = customerRepo;
        _dbContext = dbcontext;
    }

    public void Execute(CreateCustomerDto customerDto)
    {
        var customer = new Domain.Customer(customerDto.name,customerDto.companyGroup, customerDto.companyGroup, customerDto.isOnPremise,true);
        _dbContext.AddAsync(customer);
    }
}
