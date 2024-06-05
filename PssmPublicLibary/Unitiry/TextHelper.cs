using System;
using System.Security.Cryptography;
using System.Text;

namespace PssmPublicLibary.Unitiry
{
    /// <summary>
    /// 公共类
    /// </summary>
    public class TextHelper
    {

        #region Md5密码32位
        /// <summary>
        /// Md5密码32位
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetMd532(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string strMd5 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(text)));
            strMd5 = strMd5.Replace("-", "");
            return strMd5.ToLower();
        }
        #endregion

        #region Md5密码16位
        /// <summary>
        /// Md5密码16位
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetMd516(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string strMd5 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(text)), 4, 8);
            strMd5 = strMd5.Replace("-", "");
            return strMd5.ToLower();
        }
        #endregion
    }
}
