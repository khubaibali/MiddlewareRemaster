using Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TaskTemplate.Templates;

public sealed class SurveyProcessOnprem : Template
{
    public bool EmailEnabled { get; set; } = true;
    public bool SMSEnabled { get; set; } = true;
    public bool RemoveDuplicateRecords { get; set; } = true;

    public QualtricsGateway QualtricsGateway { get; private set; }
    public SurveyProcessOnprem() { }

}
