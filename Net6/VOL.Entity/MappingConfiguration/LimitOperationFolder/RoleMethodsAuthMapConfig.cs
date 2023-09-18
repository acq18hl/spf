using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class RoleMethodsAuthMapConfig : EntityMappingConfiguration<RoleMethodsAuth>
    {
        public override void Map(EntityTypeBuilder<RoleMethodsAuth>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

