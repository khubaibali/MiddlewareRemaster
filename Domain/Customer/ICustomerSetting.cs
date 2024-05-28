using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;
public interface ICustomerSetting
{
    Dictionary<string, string> SettingValues();
    string SettingValues(CustomerSettingType type);
    void SetSettingValue(CustomerSettingType type);
}
