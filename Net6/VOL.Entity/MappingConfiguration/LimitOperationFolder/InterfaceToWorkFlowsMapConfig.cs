using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class InterfaceToWorkFlowsMapConfig : EntityMappingConfiguration<InterfaceToWorkFlows>
    {
        public override void Map(EntityTypeBuilder<InterfaceToWorkFlows>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

