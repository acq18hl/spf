/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "工作流步骤",TableName = "WorkFlowStep")]
    public partial class WorkFlowStep:BaseEntity
    {
        /// <summary>
       ///
       /// </summary>
       [Key]
       [Display(Name ="Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WF_Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int WF_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepSerils")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string StepSerils { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string StepName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepAddr")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string StepAddr { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="NextStepSerils")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string NextStepSerils { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EvaluateMode")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string EvaluateMode { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ApproverUserSetting")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ApproverUserSetting { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="EndHours")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? EndHours { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IfEditFile")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string IfEditFile { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="IfDelFile")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string IfDelFile { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="OperateUserList")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string OperateUserList { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? CreateID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Creator")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Creator { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? ModifyID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Modifier")]
       [MaxLength(30)]
       [Column(TypeName="nvarchar(30)")]
       [Editable(true)]
       public string Modifier { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TerminateStatus")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? TerminateStatus { get; set; }

       
    }
}