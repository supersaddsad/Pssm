using System;
using System.Collections.Generic;
using System.Text;

namespace YourNamespace //�޸����ֿռ�
{
	public class Tb_Real
	{
		/// <summary>
		/// �޲ι��췽��
		/// </summary>
		public Tb_Real(){ }
	
		/// <summary>
		/// ���ݿ�ǿ��ֶεĹ��췽��
		/// </summary>
		public Tb_Real(long reID)
		{
			this.reID = reID;
		}
	
		/// <summary>
		/// ָ���ֶεĹ��췽��
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