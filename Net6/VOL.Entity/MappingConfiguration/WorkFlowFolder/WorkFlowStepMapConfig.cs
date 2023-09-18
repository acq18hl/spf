using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class WorkFlowStepMapConfig : EntityMappingConfiguration<WorkFlowStep>
    {
        public override void Map(EntityTypeBuilder<WorkFlowStep>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

