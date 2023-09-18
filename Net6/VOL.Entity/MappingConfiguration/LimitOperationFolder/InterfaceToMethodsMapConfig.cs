using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class InterfaceToMethodsMapConfig : EntityMappingConfiguration<InterfaceToMethods>
    {
        public override void Map(EntityTypeBuilder<InterfaceToMethods>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

