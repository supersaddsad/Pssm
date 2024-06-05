using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PssmModel.StaticModel
{
    /// <summary>
    /// 静态实体
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        public static long Realid { get; set; }

    }
}
