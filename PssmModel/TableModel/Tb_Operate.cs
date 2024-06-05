using System;

namespace YourNamespace //修改名字空间
{
    public class Tb_Operate
    {
        /// <summary>
        /// 无参构造方法
        /// </summary>
        public Tb_Operate() { }

        /// <summary>
        /// 数据库非空字段的构造方法
        /// </summary>
        public Tb_Operate(int iD, string operateType, DateTime operateTime, string opertePerson, string statr, string computName, string operateSystem)
        {
            this.iD = iD;
            this.operateType = operateType;
            this.operateTime = operateTime;
            this.opertePerson = opertePerson;
            this.statr = statr;
            this.computName = computName;
            this.operateSystem = operateSystem;
        }

        /// <summary>
        /// 指定字段的构造方法
        /// </summary>
        public Tb_Operate(int iD, string operateType, DateTime operateTime, string opertePerson, string statr, string computName, string operateSystem, int codeType, string iP)
        {
            this.iD = iD;
            this.operateType = operateType;
            this.operateTime = operateTime;
            this.opertePerson = opertePerson;
            this.statr = statr;
            this.computName = computName;
            this.operateSystem = operateSystem;
            this.codeType = codeType;
            this.iP = iP;
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string operateType;
        public string OperateType
        {
            get { return operateType; }
            set { operateType = value; }
        }

        private DateTime operateTime;
        public DateTime OperateTime
        {
            get { return operateTime; }
            set { operateTime = value; }
        }

        private string opertePerson;
        public string OpertePerson
        {
            get { return opertePerson; }
            set { opertePerson = value; }
        }

        private string statr;
        public string Statr
        {
            get { return statr; }
            set { statr = value; }
        }

        private string computName;
        public string ComputName
        {
            get { return computName; }
            set { computName = value; }
        }

        private string operateSystem;
        public string OperateSystem
        {
            get { return operateSystem; }
            set { operateSystem = value; }
        }

        private int codeType;
        public int CodeType
        {
            get { return codeType; }
            set { codeType = value; }
        }

        private string iP;
        public string IP
        {
            get { return iP; }
            set { iP = value; }
        }
    }
}