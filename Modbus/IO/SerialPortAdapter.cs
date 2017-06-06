using System;
using System.Diagnostics;
using System.IO.Ports;

namespace NJUST.AUTO06.Modbus.IO
{
	/// <summary>
	/// �����Ž����ģʽ�Ĵ�����������
	/// </summary>
	public class SerialPortAdapter : IStreamResource
	{
		private SerialPort _serialPort;

		public SerialPortAdapter(SerialPort serialPort)
		{
			Debug.Assert(serialPort != null, "SerialPort�����������Ϊ�գ�");

			_serialPort = serialPort;
		}

        /// <summary>
        /// ָʾ��������ʱ
        /// </summary>
		public int InfiniteTimeout
		{
			get { return SerialPort.InfiniteTimeout; }
		}

        /// <summary>
        /// ��������ʱʱ��
        /// </summary>
		public int ReadTimeout
		{
			get { return _serialPort.ReadTimeout; }
			set { _serialPort.ReadTimeout = value; }
		}

        /// <summary>
        /// д������ʱʱ��
        /// </summary>
		public int WriteTimeout
		{
			get { return _serialPort.WriteTimeout; }
			set { _serialPort.WriteTimeout = value; }
		}

        /// <summary>
        /// ������뻺����
        /// </summary>
		public void DiscardInBuffer()
		{
			_serialPort.DiscardInBuffer();
		}

        /// <summary>
        /// �ӽ��ջ�������ȡ�յ�����
        /// </summary>
        /// <param name="buffer">�洢�������ݵ��ֽ�����</param>
        /// <param name="offset">�����ֽڴ洢�������е�ƫ����</param>
        /// <param name="count">�����ֽ���</param>
        /// <returns></returns>
		public int Read(byte[] buffer, int offset, int count)
		{
			return _serialPort.Read(buffer, offset, count);
		}

        /// <summary>
        /// ���ͻ���������
        /// </summary>
        /// <param name="buffer">�洢�������ݵ��ֽ�����</param>
        /// <param name="offset">�����ֽ��������е�ƫ����</param>
        /// <param name="count">�����ֽ���</param>
		public void Write(byte[] buffer, int offset, int count)
		{
			_serialPort.Write(buffer, offset, count);
		}
	}
}
