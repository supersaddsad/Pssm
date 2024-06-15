using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using Pssm.DALFactory;
using Pssm.Properties;
using PssmBLL.BLL.SystemInitialize_BLL;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Utilities;
using System;
using DevExpress.Utils.Helpers;
using DevExpress.XtraBars.Ribbon;
using Pssm.Unitiy;

namespace Pssm
{
    public partial class FmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        volatile bool hasGetItemData = false;
        string defaultSkinName;
        private SystemInitialize_BLL systemInitializeDal = new SystemInitialize_BLL();
        public FmMain()
        {
            InitializeComponent();
            DataInitial();
            skinBarSubItem1.GetItemData += SkinBarSubItem1_GetItemData;
         
      
        }

        #region 皮肤本地
        /// <summary>
        /// 皮肤本地
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinBarSubItem1_GetItemData(object sender, EventArgs e)
        {
            if (!hasGetItemData)
            {
                hasGetItemData = true;
                BarSubItem barSubItem = (BarSubItem)sender;
                BarItemLinkCollection barItemLinks = barSubItem.ItemLinks;
                addSkinItemClick(barItemLinks);
            }
        }

        private void addSkinItemClick(BarItemLinkCollection collection)
        {
            foreach (BarItemLink itemLink in collection)
            {
                if (itemLink.Item is BarSubItem)
                {
                    addSkinItemClick(((BarSubItem)itemLink.Item).ItemLinks);
                }
                else
                {
                    itemLink.Item.ItemClick += changeSkin;
                }
            }
        }
        void changeSkin(object sender, ItemClickEventArgs e)
        {
            defaultSkinName = e.Item.Caption;
            XmlDocument doc = new XmlDocument();
            doc.Load("SkinInfo.xml");
            XmlNodeList nodelist = doc.SelectSingleNode("SetSkin").ChildNodes;
            foreach (XmlNode node in nodelist)
            {
                XmlElement xe = (XmlElement)node;//将子节点类型转换为XmlElement类型
                if (xe.Name == "Skinstring")
                {
                    xe.InnerText = defaultSkinName;
                }
            }

            doc.Save("SkinInfo.xml");
            skinBarSubItem1.Caption = "主题：" + defaultSkinName;
        }

        #endregion

        #region 数据初始化
        /// <summary>
        /// 数据初始化
        /// </summary>
        public void DataInitial()
        {
            CheckFile();//检查文件
            GetXmlSkin();//获取xml主题
            UserLookAndFeel.Default.SetSkinStyle(defaultSkinName);//设置主题样式
            skinBarSubItem1.Caption = "主题：" + defaultSkinName;
            Sbar.ElementClick += Sbar_ElementClick;
            SetLeftMenu();
        }

        #endregion

        #region 项目点击事件
        /// <summary>
        /// 项目点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sbar_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (e.Element.Style != ElementStyle.Group)
            {
                if (e.Element.Tag.Equals("SystemInitial"))
                {
                    SystemInitialize();
                    return;
                }
                else
                {
                  string  ClassName = e.Element.Tag as string;
                    DataAccessFactory.OpenForm(ClassName);
                }
            }
        }

        #endregion

        #region 右侧数据准备
        /// <summary>
        /// 右侧数据准备
        /// </summary>
        private void SetLeftMenu()
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
                            Tag = xeNode.GetAttribute("FrmName"),
                            Image = Image.FromFile(xeNode.GetAttribute("imageSrc")),
                            Height = Sbar.Height / 10
                        };
                        Sbar.Elements[x].Elements.Add(subitem);
                    }

                    x++;
                }
            }

            Sbar.Elements.Add(acRootGroupHome);

        }
        #endregion

        #region 系统初始化
        /// <summary>
        /// 系统初始化
        /// </summary>
        private void SystemInitialize()
        {
            if (CommMessageBox.YesNoMesBox(Resources.SystemInitialize) == DialogResult.Yes)
            {
                if (systemInitializeDal.SystemInitialize())
                {
                    CommMessageBox.MesBox(Resources.SaveSucce);
                }
                else
                {
                    CommMessageBox.MesBoxError(Resources.SaveFail);
                }

            }
            
        }
        #endregion

        #region 创建皮肤XML
        /// <summary>
        /// 创建皮肤XML
        /// </summary>
        public void CheckFile()
        {
            try
            {
                if (System.IO.File.Exists("SkinInfo.xml") == false)
                {
                    CreateXml();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateXml()
        {
            XmlDocument doc = new XmlDocument(); //建立xml定义声明
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            XmlElement root = doc.CreateElement("SetSkin"); //创建根节点
            XmlElement rootone = doc.CreateElement("Skinstring");//皮肤
            doc.AppendChild(root);//将one，two，插入到root节点下
            root.AppendChild(rootone);
            doc.Save("SkinInfo.xml");//保存皮肤名称文件为xml格式
        }

        public void GetXmlSkin()
        {
            try
            {
                XmlDocument mydoc = new XmlDocument();
                mydoc.Load("SkinInfo.xml");//从xml文件中提取皮肤名称
                XmlNode ressNode = mydoc.SelectSingleNode("SetSkin");//头和尾
                defaultSkinName = ressNode.SelectSingleNode("Skinstring").InnerText;//把提取出来的皮肤名称存到defaultSkinName中

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}