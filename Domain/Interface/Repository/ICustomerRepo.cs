﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Repository;

public interface ICustomerRepo
{
    void Add(Customer customer);
}
