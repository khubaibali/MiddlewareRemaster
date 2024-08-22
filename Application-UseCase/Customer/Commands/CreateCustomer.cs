using Application_UseCase.DTOs;
using Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_UseCase.Customer.Commands;

public sealed class CreateCustomer
{
    private readonly ICustomerRepo _customerRepo;

    public CreateCustomer(ICustomerRepo customerRepo)
    {
        _customerRepo = customerRepo;
    }

    public CreateCustomer(CreateCustomerDto dto) 
    {
        var customer = new Domain.Customer(dto.name,dto.isOnPremise,true);
        
    }


}
