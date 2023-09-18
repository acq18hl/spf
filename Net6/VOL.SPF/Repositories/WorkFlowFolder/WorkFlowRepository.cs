/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹WorkFlowRepository编写代码
 */
using VOL.SPF.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.SPF.Repositories
{
    public partial class WorkFlowRepository : RepositoryBase<WorkFlow> , IWorkFlowRepository
    {
    public WorkFlowRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IWorkFlowRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IWorkFlowRepository>(); } }
    }
}
