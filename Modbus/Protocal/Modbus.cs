namespace NJUST.AUTO06.Modbus.Protocal
{	
	/// <summary>
	///  ����MODBUSЭ��Ĺ����뼰��������
	/// </summary>
	public static class ModbusCommand
	{			
		// ModbusЭ��Ĺ����붨��
        public const byte ReadCoils                  = 0x01; // ����Ȧ״̬    
        public const byte ReadInputs                 = 0x02; // ������������״̬  
        public const byte ReadHoldingRegisters       = 0x03; // �����ּĴ�����ֵ  
		public const byte ReadInputRegisters         = 0x04; // ��ȡ����Ĵ���
        public const byte WriteSingleCoil            = 0x05; // д����Ȧ״̬
        public const byte WriteSingleRegister        = 0x06; // д���Ĵ���
        public const byte WriteMultipleCoils         = 0x0F; // д����Ȧ״̬  
        public const byte WriteMultipleRegisters     = 0x10; // д��Ĵ���

        public const byte RTUErrorCodeSize           = 0x05; // Modbus RTUЭ��Ĵ�����֡����
        public const byte TCPErrorCodeSize           = 0x09; // Modbus TCPЭ��Ĵ�����֡����

		// ����֡�������ƫ������=���湦����+0x80��
		public const byte ExceptionOffset = 0x80;

		// IO������ȱʡ�ش�����
		public const int DefaultRetries = 2;

		// д����ȱʡ�ȴ�ʱ�䣨ms��
		public const int DefaultWaitToRetryMilliseconds = 250;

		// ������ȱʡ�ȴ�ʱ�䣨ms��
		public const int DefaultTimeout = 500;

        // ��Ȧ������1��0
		public const ushort CoilOn = 0xFF00;
		public const ushort CoilOff = 0x0000;
	
	}
}
