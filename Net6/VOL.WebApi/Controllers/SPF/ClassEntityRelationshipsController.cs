/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹ClassEntityRelationshipsController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.SPF.IServices;
namespace VOL.SPF.Controllers
{
    [Route("api/ClassEntityRelationships")]
    [PermissionTable(Name = "ClassEntityRelationships")]
    public partial class ClassEntityRelationshipsController : ApiBaseController<IClassEntityRelationshipsService>
    {
        public ClassEntityRelationshipsController(IClassEntityRelationshipsService service)
        : base(service)
        {
        }
    }
}

