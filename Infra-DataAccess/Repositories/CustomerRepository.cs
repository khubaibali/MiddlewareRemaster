using Domain;
using Domain.Interface.Repository;
using Infra_DataAccess.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_DataAccess.Repositories;

public class CustomerRepository :  ICustomerRepo
{
    private readonly MiddlewareDbContext _context;
    public CustomerRepository(MiddlewareDbContext context)
    {
        _context = context;
    }

    public void Add(Customer customer)
    {
        _context.Add(customer);
    }
}
