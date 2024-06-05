using Message.Properties;
using System.Text;
using System.Windows.Forms;


namespace Utilities
{
    //页面中弹出对话框
    public class CommMessageBox
    {

        public static string Caption = Resources.SystemAlert;


        #region 对话框
        /// <summary>
        /// 对话框
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns> 

        public static DialogResult MesBox(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 警告对话框
        /// <summary>
        /// 警告对话框
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns> 

        public static DialogResult MesBoxCaveat(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region 错误信息对话框
        /// <summary>
        /// 错误信息对话框
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns> 

        public static DialogResult MesBoxError(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region 执行确认信息对话框
        /// <summary>
        /// 执行确认信息对话框
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns> 

        public static DialogResult YesNoMesBox(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        #region 执行确认对话框
        /// <summary>
        /// 执行确认对话框
        /// </summary>
        /// <param name="sMsg"></param>
        /// <returns></returns> 
        public static DialogResult OKCancelMesBox(string sMsg)
        {
            return MessageBox.Show(sMsg, Caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
        #endregion

    }
}