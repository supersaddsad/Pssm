using DevExpress.XtraEditors;
using System.Reflection;
using System.Windows.Forms;

namespace Pssm.DALFactory
{

    public class DataAccessFactory
    {

        #region 创建类对象实例
        /// <summary>
        /// 创建类对象实例
        /// </summary>
        private static XtraForm GetInstance(string className)
        {
            string[] configNamesSplit = Assembly.GetExecutingAssembly().GetName().Name.Split('.');
            string configName = string.Join(",", configNamesSplit[0]);
            Assembly assembly = Assembly.Load(configName);
            string assName = string.Format("{0}.{1}", configName, className);
            return assembly.CreateInstance(assName) as XtraForm;
        }
        #endregion


        #region 打开窗体
        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param name="className"></param>
        public static void OpenForm(string className)
        {
            XtraForm form = GetInstance(className);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
        #endregion


        public static XtraForm OpenForm(string folder, string className)
        {
            XtraForm form = GetInstance($"{folder}.{className}");
            form.StartPosition = FormStartPosition.CenterScreen;
            return form;
        }
    }
}
