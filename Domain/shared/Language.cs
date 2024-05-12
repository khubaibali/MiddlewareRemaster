using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.shared;

public sealed class Language
{
    public string Value {  get; private set; }
    public Language(string value)
    {
        if(value.ToLower().Trim() == "en")
        {
            Value = value.ToUpper().Trim();
        }
        if (value.ToLower().Trim() == "ar")
        {
            Value = value.ToUpper().Trim();
        }
        throw new FormatException("In valid language code exception");
    }
    public Language() 
    {
        Value = "EN";
    }
}
