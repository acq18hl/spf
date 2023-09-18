using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class WorkFlowMapConfig : EntityMappingConfiguration<WorkFlow>
    {
        public override void Map(EntityTypeBuilder<WorkFlow>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

