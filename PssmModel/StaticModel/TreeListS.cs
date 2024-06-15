using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PssmModel.StaticModel
{
    public class TreeListS
    {
        /// <summary>
        /// 节点编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 父节点编号
        /// </summary>
        public int ParentId { get; set; }


        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

    }
}
