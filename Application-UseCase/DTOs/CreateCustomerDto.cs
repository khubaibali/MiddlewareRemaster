using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_UseCase.DTOs;

public record CreateCustomerDto(string name,string company,string companyGroup, string phoneNumber, bool isOnPremise= false);

