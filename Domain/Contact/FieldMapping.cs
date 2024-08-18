using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class FieldMapping
{
    public string SourceFieldName { get; private set; }
    public string TargetFieldName { get; private set; }
    public FieldMapType MapType { get; private set; }

    #region Constructors
    private FieldMapping() { }
    public FieldMapping(string sourceFieldName, string targetFieldName, FieldMapType mapType)
    {
        SourceFieldName = sourceFieldName;
        TargetFieldName = targetFieldName;
        MapType = mapType;
    }
    #endregion
}
