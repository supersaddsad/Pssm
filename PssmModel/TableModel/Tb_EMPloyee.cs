using System;
using System.Collections.Generic;
using System.Text;

namespace YourNamespace //修改名字空间
{
	public class Tb_EMPloyee
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public Tb_EMPloyee(){ }
	
		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public Tb_EMPloyee(int empID,string logID)
		{
			this.empID = empID;
			this.logID = logID;
		}
	
		/// <summary>
		/// 指定字段的构造方法
		/// </summary>
		public Tb_EMPloyee(int empID,string name,string logID,int sex,int iDCode,DateTime birthday,int departmentID,bool isEnable)
		{
			this.empID = empID;
			this.name = name;
			this.logID = logID;
			this.sex = sex;
			this.iDCode = iDCode;
			this.birthday = birthday;
			this.departmentID = departmentID;
			this.isEnable = isEnable;
		}
	
		private int empID;
		public int EmpID
		{
			get { return empID; }
			set { empID = value; }
		}
	
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	
		private string logID;
		public string LogID
		{
			get { return logID; }
			set { logID = value; }
		}
	
		private int sex;
		public int Sex
		{
			get { return sex; }
			set { sex = value; }
		}
	
		private int iDCode;
		public int IDCode
		{
			get { return iDCode; }
			set { iDCode = value; }
		}
	
		private DateTime birthday;
		public DateTime Birthday
		{
			get { return birthday; }
			set { birthday = value; }
		}
	
		private int departmentID;
		public int DepartmentID
		{
			get { return departmentID; }
			set { departmentID = value; }
		}
	
		private bool isEnable;
		public bool IsEnable
		{
			get { return isEnable; }
			set { isEnable = value; }
		}
	}
}