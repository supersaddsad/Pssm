using System;
using System.Collections.Generic;
using System.Text;

namespace YourNamespace //�޸����ֿռ�
{
	public class Tb_Deptment
	{
		/// <summary>
		/// �޲ι��췽��
		/// </summary>
		public Tb_Deptment(){ }
	
		/// <summary>
		/// ���ݿ�ǿ��ֶεĹ��췽��
		/// </summary>
		public Tb_Deptment(int deptID,string deptName)
		{
			this.deptID = deptID;
			this.deptName = deptName;
		}
	
		/// <summary>
		/// ָ���ֶεĹ��췽��
		/// </summary>
		public Tb_Deptment(int deptID,string deptName,string remark,bool isEnable,int parentID,DateTime lMTime)
		{
			this.deptID = deptID;
			this.deptName = deptName;
			this.remark = remark;
			this.isEnable = isEnable;
			this.parentID = parentID;
			this.lMTime = lMTime;
		}
	
		private int deptID;
		public int DeptID
		{
			get { return deptID; }
			set { deptID = value; }
		}
	
		private string deptName;
		public string DeptName
		{
			get { return deptName; }
			set { deptName = value; }
		}
	
		private string remark;
		public string Remark
		{
			get { return remark; }
			set { remark = value; }
		}
	
		private bool isEnable;
		public bool IsEnable
		{
			get { return isEnable; }
			set { isEnable = value; }
		}
	
		private int parentID;
		public int ParentID
		{
			get { return parentID; }
			set { parentID = value; }
		}
	
		private DateTime lMTime;
		public DateTime LMTime
		{
			get { return lMTime; }
			set { lMTime = value; }
		}
	}
}