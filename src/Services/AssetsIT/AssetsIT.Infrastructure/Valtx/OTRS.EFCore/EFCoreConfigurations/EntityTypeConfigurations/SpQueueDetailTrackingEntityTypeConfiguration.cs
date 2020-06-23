using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class SpQueueDetailTrackingEntityTypeConfiguration : IEntityTypeConfiguration<SpDetalleTracking>
    {
        public void Configure(EntityTypeBuilder<SpDetalleTracking> builder)
        {
            builder.ToView("sp_detalle_tracking");
            
            builder.HasNoKey();

            builder.Property(e => e.QueueId)
                .HasColumnName("queue_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ArticuloId)
                .HasColumnName("articulo_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ABody)
                .HasColumnName("a_body")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");            

            builder.Property(e => e.CreatedTime)
                .HasColumnName("create_time");

            builder.Property(e => e.CreadoPor)
                .HasColumnName("CreadoPor")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Especialista)
                .HasColumnName("Especialista")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TipoHistoria)
                .HasColumnName("tipo_historia");
        }
    }
}
