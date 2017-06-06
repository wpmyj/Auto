using System;
using System.Windows.Forms;

namespace NJUST.AUTO06.Utility
{
	/// <summary>
	/// MessageUtil ��ժҪ˵��
    /// ������ര�ڵ�����Ϣ
	/// </summary>
	public class MessageUtil
	{
		/// <summary>
		/// ��ʾһ�����ʾ��Ϣ
		/// </summary>
		/// <param name="message">��ʾ��Ϣ</param>
		public static DialogResult ShowTips(string message)
		{
			return MessageBox.Show(message, "��ʾ��Ϣ",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// ��ʾ������Ϣ
		/// </summary>
		/// <param name="message">������Ϣ</param>
		public static DialogResult ShowWarning(string message)
		{
			return MessageBox.Show(message, "������Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		/// <summary>
		/// ��ʾ������Ϣ
		/// </summary>
		/// <param name="message">������Ϣ</param>
		public static DialogResult ShowError(string message)
		{
			return MessageBox.Show(message, "������Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// ��ʾѯ���û���Ϣ������ʾ�����־
		/// </summary>
		/// <param name="message">������Ϣ</param>
		public static DialogResult ShowYesNoAndError(string message)
		{
			return MessageBox.Show(message, "������Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
		}

		/// <summary>
		/// ��ʾѯ���û���Ϣ������ʾ��ʾ��־
		/// </summary>
		/// <param name="message">������Ϣ</param>
		public static DialogResult ShowYesNoAndTips(string message)
		{
			return MessageBox.Show(message, "��ʾ��Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
		}

        /// <summary>
        /// ��ʾѯ���û���Ϣ������ʾ�����־
        /// </summary>
        /// <param name="message">������Ϣ</param>
        public static DialogResult ShowYesNoAndWarning(string message)
        {
            return MessageBox.Show(message, "������Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// ��ʾѯ���û���Ϣ������ʾ��ʾ��־
        /// </summary>
        /// <param name="message">������Ϣ</param>
        public static DialogResult ShowYesNoCancelAndTips(string message)
        {
            return MessageBox.Show(message, "��ʾ��Ϣ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }
	}
}
