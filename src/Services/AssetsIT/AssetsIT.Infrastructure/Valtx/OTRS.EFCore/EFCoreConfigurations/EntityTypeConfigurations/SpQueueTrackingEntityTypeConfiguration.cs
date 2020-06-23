using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class SpQueueTrackingEntityTypeConfiguration : IEntityTypeConfiguration<SpCabeceraTracking>
    {
        public void Configure(EntityTypeBuilder<SpCabeceraTracking> builder)
        {
            builder.ToView("sp_cabecera_tracking");

            builder.HasNoKey();

            builder.Property(e => e.Tin)
                .HasColumnName("tin")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.IdTipo)
                .HasColumnName("idtipo")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Tipo)
                .HasColumnName("tipo")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Tarea)
                .HasColumnName("tarea")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Cola)
                .HasColumnName("cola")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.FlujoCola)
                .HasColumnName("flujo_cola")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Temp1)
                .HasColumnName("temp1")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Temp2)
                .HasColumnName("temp2")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Diferencia)
                .HasColumnName("diferencia")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Estado)
                .HasColumnName("Estado")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}
