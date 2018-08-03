//=====================================================================================
// All Rights Reserved , Copyright @ Hexagon 2017
// Software Developers @ Hexagon 2017
//=====================================================================================

using Hexagon.Data.Attributes;
using System;
using System.ComponentModel;

namespace Hexagon.Entity
{
    /// <summary>
    /// ͨѶ¼����
    /// <author>
    ///		<name>she</name>
    ///		<date>2017.05.06 15:45</date>
    /// </author>
    /// </summary>
    [Description("ͨѶ¼����")]
    [PrimaryKey("EMPLOYEE_ID")]
    public class Organization_Employee : BaseEntity
    {
        #region ��ȡ/���� �ֶ�ֵ
        /// <summary>
        /// ��ϵ��ID
        /// </summary>
        /// <returns></returns>
        [DisplayName("��ϵ��ID")]
        public double EMPLOYEE_ID { get; set; }
        /// <summary>
        /// ��ϵ������
        /// </summary>
        /// <returns></returns>
        [DisplayName("��ϵ������")]
        public string EMPLOYEE_NAME { get; set; }
        /// <summary>
        /// �Ա�
        /// </summary>
        /// <returns></returns>
        [DisplayName("�Ա�")]
        public string GENDER { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        [DisplayName("��������")]
        public DateTime? BIRTHDAY { get; set; }
        /// <summary>
        /// ֤������
        /// </summary>
        /// <returns></returns>
        [DisplayName("֤������")]
        public string CERTIFICATE_TYPE { get; set; }
        /// <summary>
        /// ֤������
        /// </summary>
        /// <returns></returns>
        [DisplayName("֤������")]
        public string CERTIFICATE_CODE { get; set; }
        /// <summary>
        /// ��ϵ�绰
        /// </summary>
        /// <returns></returns>
        [DisplayName("��ϵ�绰")]
        public string CONTACT_PHONE { get; set; }
        /// <summary>
        /// �칫�绰1
        /// </summary>
        /// <returns></returns>
        [DisplayName("�칫�绰1")]
        public string OFFICE_TELEPHONE1 { get; set; }
        /// <summary>
        /// �칫�绰2
        /// </summary>
        /// <returns></returns>
        [DisplayName("�칫�绰2")]
        public string OFFICE_TELEPHONE2 { get; set; }
        /// <summary>
        /// �칫����
        /// </summary>
        /// <returns></returns>
        [DisplayName("�칫����")]
        public string OFFICE_FAX { get; set; }
        /// <summary>
        /// �����ʼ�
        /// </summary>
        /// <returns></returns>
        [DisplayName("�����ʼ�")]
        public string EMAIL { get; set; }
        /// <summary>
        /// ��ͥ�绰
        /// </summary>
        /// <returns></returns>
        [DisplayName("��ͥ�绰")]
        public string HOME_TELEPHONE { get; set; }

        /// <summary>
        /// ��ͥ��ַ
        /// </summary>
        /// <returns></returns>
        [DisplayName("��ͥ��ַ")]
        public string HOME_ADDRESS { get; set; }
        /// <summary>
        /// ְ������
        /// </summary>
        /// <returns></returns>
        [DisplayName("ְ������")]
        public string DUTY_DESC { get; set; }
        /// <summary>
        /// ��λID
        /// </summary>
        /// <returns></returns>
        [DisplayName("��λID")]
        public string ORGANIZATION_ID { get; set; }
        /// <summary>
        /// �칫�ҷ����
        /// </summary>
        /// <returns></returns>
        [DisplayName("�칫�ҷ����")]
        public string ROOM_NUM { get; set; }
       
        /// <summary>
        /// ˾���绰
        /// </summary>
        /// <returns></returns>
        [DisplayName("˾���绰")]
        public string DRIVER_PHONE { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        /// <returns></returns>
        [DisplayName("��ע")]
        public string NOTE { get; set; }
        /// <summary>
        /// ����绰
        /// </summary>
        /// <returns></returns>
        [DisplayName("����绰")]
        public string SECRETARY_PHONE { get; set; }

        /// <summary>
        /// ��Ч��־
        /// </summary>
        /// <returns></returns>
        [DisplayName("��Ч��־")]
        public int? ISVALID { get; set; }
        //public int? Online { get; set; }
        
        /// <summary>
        /// UC�˺�
        /// </summary>
        /// <returns></returns>
        [DisplayName("UC�˺�")]
        public string ESPACE_ACCOUNT { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        /// <returns></returns>
        [DisplayName("�������")]
        public string SERVICE_NUMBER { get; set; }
        /// <summary>
        /// UC���ñ�־
        /// </summary>
        /// <returns></returns>
        [DisplayName("UC���ñ�־")]
        public int? UC_ENABLE { get; set; }
        
        /// <summary>
        /// ����ʱ��
        /// </summary>
        /// <returns></returns>
        [DisplayName("����ʱ��")]
        public DateTime? CREATED_DATE { get; set; }
       
        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        /// <returns></returns>
        [DisplayName("�޸�ʱ��")]
        public DateTime? MODIFIED_DATE { get; set; }

        /// <summary>
        /// ͷ��
        /// </summary>
        /// <returns></returns>
        [DisplayName("ͷ��")]
        public string HeadIcon { get; set; }
        #endregion

        #region ��չ����
        /// <summary>
        /// ��������
        /// </summary>
        public override void Create()
        {
            //this.UserId = CommonHelper.GetGuid;
            this.CREATED_DATE = DateTime.Now;
        }
        /// <summary>
        /// �༭����
        /// </summary>
        /// <param name="KeyValue"></param>
        public override void Modify(string KeyValue)
        {
            //this.UserId = KeyValue;
            this.MODIFIED_DATE = DateTime.Now;
        }
        #endregion
    }
}