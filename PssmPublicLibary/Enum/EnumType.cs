using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PssmPublicLibary.Enum
{
    public enum EnumCOdeType : int
    {
        [Description("系统登陆")]
        SystemLogin=1,
            
            
        [Description("员工增加")]
        EmpLoyeeAdd = 2

    }
}
