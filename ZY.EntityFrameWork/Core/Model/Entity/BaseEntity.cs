using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ZY.EntityFrameWork.Core.Model.Entity
{
    /// <summary>
    /// �������
    /// </summary>
    public class BaseEntity
    {
        // ��һ�޶���ID
        public string ID { get; set; }

        //MySQL��������������������
        //MySqlMigrationSqlGenerator������byte[]�����ϱ��TimeStamp/RowVersion������ʹ��DateTime����
        //[Timestamp]
        //public byte[] RowVersion { get; set; }       
    }
}