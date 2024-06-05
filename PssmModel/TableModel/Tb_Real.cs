using System;
using System.Collections.Generic;
using System.Text;

namespace YourNamespace //修改名字空间
{
	public class Tb_Real
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public Tb_Real(){ }
	
		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public Tb_Real(long reID)
		{
			this.reID = reID;
		}
	
		/// <summary>
		/// 指定字段的构造方法
		/// </summary>
		public Tb_Real(long reID,string reName)
		{
			this.reID = reID;
			this.reName = reName;
		}
	
		private long reID;
		public long ReID
		{
			get { return reID; }
			set { reID = value; }
		}
	
		private string reName;
		public string ReName
		{
			get { return reName; }
			set { reName = value; }
		}
	}
}