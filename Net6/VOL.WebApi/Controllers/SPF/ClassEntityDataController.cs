/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ClassEntityDataController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.SPF.IServices;
namespace VOL.SPF.Controllers
{
    [Route("api/ClassEntityData")]
    [PermissionTable(Name = "ClassEntityData")]
    public partial class ClassEntityDataController : ApiBaseController<IClassEntityDataService>
    {
        public ClassEntityDataController(IClassEntityDataService service)
        : base(service)
        {
        }
    }
}

