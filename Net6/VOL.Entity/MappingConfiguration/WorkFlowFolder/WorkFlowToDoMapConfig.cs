using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class WorkFlowToDoMapConfig : EntityMappingConfiguration<WorkFlowToDo>
    {
        public override void Map(EntityTypeBuilder<WorkFlowToDo>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

