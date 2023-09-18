/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹WorkFlowToDoController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.SPF.IServices;
namespace VOL.SPF.Controllers
{
    [Route("api/WorkFlowToDo")]
    [PermissionTable(Name = "WorkFlowToDo")]
    public partial class WorkFlowToDoController : ApiBaseController<IWorkFlowToDoService>
    {
        public WorkFlowToDoController(IWorkFlowToDoService service)
        : base(service)
        {
        }
    }
}

