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
    [Entity(TableCnName = "工作流执行",TableName = "WorkFlowToDo")]
    public partial class WorkFlowToDo:BaseEntity
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
       [Display(Name ="Object_Id")]
       [Column(TypeName="int")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public int Object_Id { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="TableName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string TableName { get; set; }

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
       [Display(Name ="WorkToDoName")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string WorkToDoName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="UserID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? UserID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AttachFilesList")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string AttachFilesList { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepsUserInfo")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       public string StepsUserInfo { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WorkFlowInfoJson")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string WorkFlowInfoJson { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepID")]
       [Column(TypeName="int")]
       [Editable(true)]
       public int? StepID { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StepName")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string StepName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ApprovalUserList")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ApprovalUserList { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PassUserList")]
       [MaxLength(2000)]
       [Column(TypeName="nvarchar(2000)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string PassUserList { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="StateNow")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string StateNow { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AllRecipientsJson")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string AllRecipientsJson { get; set; }

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