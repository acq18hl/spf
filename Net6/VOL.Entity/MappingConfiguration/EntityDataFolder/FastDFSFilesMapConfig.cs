using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class FastDFSFilesMapConfig : EntityMappingConfiguration<FastDFSFiles>
    {
        public override void Map(EntityTypeBuilder<FastDFSFiles>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

