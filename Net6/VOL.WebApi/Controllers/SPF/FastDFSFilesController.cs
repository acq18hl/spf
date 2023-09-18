/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹FastDFSFilesController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.SPF.IServices;
namespace VOL.SPF.Controllers
{
    [Route("api/FastDFSFiles")]
    [PermissionTable(Name = "FastDFSFiles")]
    public partial class FastDFSFilesController : ApiBaseController<IFastDFSFilesService>
    {
        public FastDFSFilesController(IFastDFSFilesService service)
        : base(service)
        {
        }
    }
}

