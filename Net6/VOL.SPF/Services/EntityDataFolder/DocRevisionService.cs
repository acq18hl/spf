/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下DocRevisionService与IDocRevisionService中编写
 */
using VOL.SPF.IRepositories;
using VOL.SPF.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.SPF.Services
{
    public partial class DocRevisionService : ServiceBase<DocRevision, IDocRevisionRepository>
    , IDocRevisionService, IDependency
    {
    public DocRevisionService(IDocRevisionRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IDocRevisionService Instance
    {
      get { return AutofacContainerModule.GetService<IDocRevisionService>(); } }
    }
 }
