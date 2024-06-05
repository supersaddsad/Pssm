using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraBars.Navigation;
using Message.Properties;
using PssmBLL.BLL;
using PssmModel.StaticModel;
using PssmPublicLibary;

namespace Message
{
    public partial class FmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FmMain()
        {
            InitializeComponent();
            DataInitial();
        }

        #region 数据初始化
        /// <summary>
        /// 数据初始化
        /// </summary>
        public void DataInitial()
        {
            SetLeftMenu();
        }
        #endregion

        #region 右侧数据准备
        /// <summary>
        /// 右侧数据准备
        /// </summary>
        public void SetLeftMenu()
        {
            //创建XMl对象
            XmlDocument doc = new XmlDocument();
            //加载xml
            doc.Load(Resources.LeftMenu);
            var acRootGroupHome = new AccordionControlElement();
            //读取xml节点
            XmlNode root = doc.SelectSingleNode("MenuStrip");
            acRootGroupHome.Style = ElementStyle.Group;
            //清除左侧导航栏的内容
            Sbar.Elements.Clear();
            int x = 0;
            //循环读取xml节点数据
            foreach (XmlNode xmlNode in root.ChildNodes)
            {
                XmlElement xeElement = xmlNode as XmlElement;
                Sbar.Elements.Add().Text = xeElement.GetAttribute("TextValue");
                if (xeElement.ChildNodes.Count > 0)
                {
                    foreach (XmlNode xe in xeElement.ChildNodes)
                    {
                        XmlElement xeNode = xe as XmlElement;

                        var subitem = new AccordionControlElement()
                        {
                            Style = ElementStyle.Item,
                            Name = xeNode.GetAttribute("TextValue"),
                            Text = xeNode.GetAttribute("TextValue"),
                        };
                        Sbar.Elements[x].Elements.Add(subitem);
                    }

                    x++;
                }
            }

            Sbar.Elements.Add(acRootGroupHome);
        } 
        #endregion


    }
}