/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹FastDFSFilesRepository编写代码
 */
using VOL.SPF.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.SPF.Repositories
{
    public partial class FastDFSFilesRepository : RepositoryBase<FastDFSFiles> , IFastDFSFilesRepository
    {
    public FastDFSFilesRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IFastDFSFilesRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IFastDFSFilesRepository>(); } }
    }
}
