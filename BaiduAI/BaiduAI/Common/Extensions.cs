using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiduAI.Common
{
    /// <summary>
    /// ��չ�����࣬�ṩ���õ��ַ����Ͷ�����չ����
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// ������ת��Ϊ�ַ������������Ϊnull�򷵻ؿ��ַ���
        /// </summary>
        /// <param name="obj">Ҫת���Ķ���</param>
        /// <returns>������ַ�����ʾ����ַ���</returns>
        public static string TryToString(this object obj)
        {
            if (obj == null)
                return string.Empty;
            
            return obj.ToString();
        }

        /// <summary>
        /// ����ַ����Ƿ�Ϊnull���ջ�������հ��ַ�
        /// </summary>
        /// <param name="str">Ҫ�����ַ���</param>
        /// <returns>����ַ���Ϊnull���ջ�������հ��ַ����򷵻�true�����򷵻�false</returns>
        public static bool IsNull(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}