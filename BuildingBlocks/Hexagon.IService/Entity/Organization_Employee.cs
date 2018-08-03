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
    /// 通讯录管理
    /// <author>
    ///		<name>she</name>
    ///		<date>2017.05.06 15:45</date>
    /// </author>
    /// </summary>
    [Description("通讯录管理")]
    [PrimaryKey("EMPLOYEE_ID")]
    public class Organization_Employee : BaseEntity
    {
        #region 获取/设置 字段值
        /// <summary>
        /// 联系人ID
        /// </summary>
        /// <returns></returns>
        [DisplayName("联系人ID")]
        public double EMPLOYEE_ID { get; set; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        /// <returns></returns>
        [DisplayName("联系人姓名")]
        public string EMPLOYEE_NAME { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        /// <returns></returns>
        [DisplayName("性别")]
        public string GENDER { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        /// <returns></returns>
        [DisplayName("出生日期")]
        public DateTime? BIRTHDAY { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        /// <returns></returns>
        [DisplayName("证件类型")]
        public string CERTIFICATE_TYPE { get; set; }
        /// <summary>
        /// 证件代码
        /// </summary>
        /// <returns></returns>
        [DisplayName("证件代码")]
        public string CERTIFICATE_CODE { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        /// <returns></returns>
        [DisplayName("联系电话")]
        public string CONTACT_PHONE { get; set; }
        /// <summary>
        /// 办公电话1
        /// </summary>
        /// <returns></returns>
        [DisplayName("办公电话1")]
        public string OFFICE_TELEPHONE1 { get; set; }
        /// <summary>
        /// 办公电话2
        /// </summary>
        /// <returns></returns>
        [DisplayName("办公电话2")]
        public string OFFICE_TELEPHONE2 { get; set; }
        /// <summary>
        /// 办公传真
        /// </summary>
        /// <returns></returns>
        [DisplayName("办公传真")]
        public string OFFICE_FAX { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        /// <returns></returns>
        [DisplayName("电子邮件")]
        public string EMAIL { get; set; }
        /// <summary>
        /// 家庭电话
        /// </summary>
        /// <returns></returns>
        [DisplayName("家庭电话")]
        public string HOME_TELEPHONE { get; set; }

        /// <summary>
        /// 家庭地址
        /// </summary>
        /// <returns></returns>
        [DisplayName("家庭地址")]
        public string HOME_ADDRESS { get; set; }
        /// <summary>
        /// 职务描述
        /// </summary>
        /// <returns></returns>
        [DisplayName("职务描述")]
        public string DUTY_DESC { get; set; }
        /// <summary>
        /// 单位ID
        /// </summary>
        /// <returns></returns>
        [DisplayName("单位ID")]
        public string ORGANIZATION_ID { get; set; }
        /// <summary>
        /// 办公室房间号
        /// </summary>
        /// <returns></returns>
        [DisplayName("办公室房间号")]
        public string ROOM_NUM { get; set; }
       
        /// <summary>
        /// 司机电话
        /// </summary>
        /// <returns></returns>
        [DisplayName("司机电话")]
        public string DRIVER_PHONE { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        /// <returns></returns>
        [DisplayName("备注")]
        public string NOTE { get; set; }
        /// <summary>
        /// 秘书电话
        /// </summary>
        /// <returns></returns>
        [DisplayName("秘书电话")]
        public string SECRETARY_PHONE { get; set; }

        /// <summary>
        /// 有效标志
        /// </summary>
        /// <returns></returns>
        [DisplayName("有效标志")]
        public int? ISVALID { get; set; }
        //public int? Online { get; set; }
        
        /// <summary>
        /// UC账号
        /// </summary>
        /// <returns></returns>
        [DisplayName("UC账号")]
        public string ESPACE_ACCOUNT { get; set; }
        /// <summary>
        /// 服务号码
        /// </summary>
        /// <returns></returns>
        [DisplayName("服务号码")]
        public string SERVICE_NUMBER { get; set; }
        /// <summary>
        /// UC启用标志
        /// </summary>
        /// <returns></returns>
        [DisplayName("UC启用标志")]
        public int? UC_ENABLE { get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <returns></returns>
        [DisplayName("创建时间")]
        public DateTime? CREATED_DATE { get; set; }
       
        /// <summary>
        /// 修改时间
        /// </summary>
        /// <returns></returns>
        [DisplayName("修改时间")]
        public DateTime? MODIFIED_DATE { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        /// <returns></returns>
        [DisplayName("头像")]
        public string HeadIcon { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public override void Create()
        {
            //this.UserId = CommonHelper.GetGuid;
            this.CREATED_DATE = DateTime.Now;
        }
        /// <summary>
        /// 编辑调用
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