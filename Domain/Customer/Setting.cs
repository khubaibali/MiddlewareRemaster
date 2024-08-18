using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public sealed class Setting : ICustomerSetting
{
    #region Contructors
    public Setting(Guid id, CustomerSettingType keyName, string value)
    {
        //Id = id;
        //KeyName = keyName;
        //Value = value;
    }
    #endregion

    public Dictionary<string, string> SettingValues()
    {
        throw new NotImplementedException();
    }

    public string SettingValues(CustomerSettingType type)
    {
        throw new NotImplementedException();
    }

    public void SetSettingValue(CustomerSettingType type)
    {
        throw new NotImplementedException();
    }
}
