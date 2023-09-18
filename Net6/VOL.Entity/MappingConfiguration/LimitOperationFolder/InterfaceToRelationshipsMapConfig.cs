using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class InterfaceToRelationshipsMapConfig : EntityMappingConfiguration<InterfaceToRelationships>
    {
        public override void Map(EntityTypeBuilder<InterfaceToRelationships>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

