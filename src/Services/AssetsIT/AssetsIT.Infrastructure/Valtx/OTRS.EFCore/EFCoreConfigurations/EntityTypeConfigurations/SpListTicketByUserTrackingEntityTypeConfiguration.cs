using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class SpListTicketByUserTrackingEntityTypeConfiguration : IEntityTypeConfiguration<SpListTicketsByUser>
    {
        public void Configure(EntityTypeBuilder<SpListTicketsByUser> builder) {
            builder.ToView("sp_list_tickets_by_user");

            builder.HasNoKey();

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Tn)
                .HasColumnName("tn")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.IdTipoSolicitud)
                .HasColumnName("id_tipo_solicitud")
                .HasColumnType("int(11)");

            builder.Property(e => e.FechaSolicitud)
                .HasColumnName("fecha_solicitud");

            builder.Property(e => e.TipoSolicitud)
                .HasColumnName("tipo_solicitud")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Solicitud)
                .HasColumnName("solicitud")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.IdEstado)
                .HasColumnName("id_estado")
                .HasColumnType("int(11)");

            builder.Property(e => e.Estado)
                .HasColumnName("estado")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}