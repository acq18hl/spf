/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下ClassEntityRelationshipsService与IClassEntityRelationshipsService中编写
 */
using VOL.SPF.IRepositories;
using VOL.SPF.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.SPF.Services
{
    public partial class ClassEntityRelationshipsService : ServiceBase<ClassEntityRelationships, IClassEntityRelationshipsRepository>
    , IClassEntityRelationshipsService, IDependency
    {
    public ClassEntityRelationshipsService(IClassEntityRelationshipsRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IClassEntityRelationshipsService Instance
    {
      get { return AutofacContainerModule.GetService<IClassEntityRelationshipsService>(); } }
    }
 }
