using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class VwServiceEntityTypeConfiguration : IEntityTypeConfiguration<VwService>
    {
        public void Configure(EntityTypeBuilder<VwService> builder)
        {
            builder.ToView("VW_SERVICIOS_OTRS");

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Service1)
                .HasColumnName("service1")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Service2)
                .HasColumnName("service2")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci"); 

            builder.Property(e => e.Service3)
                .HasColumnName("service3")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TypeService)
                .HasColumnName("type_service")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TypeServiceName)
                .HasColumnName("type_service_name")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ServiceFullName)
                .HasColumnName("servicefull")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}
