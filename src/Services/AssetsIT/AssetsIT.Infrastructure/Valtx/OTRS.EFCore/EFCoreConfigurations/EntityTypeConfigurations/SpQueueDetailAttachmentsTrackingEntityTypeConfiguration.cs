using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class SpQueueDetailAttachmentsTrackingEntityTypeConfiguration : IEntityTypeConfiguration<SpDetalleAdjuntosTracking>
    {
        public void Configure(EntityTypeBuilder<SpDetalleAdjuntosTracking> builder)
        {
            builder.ToView("sp_detalle_adjunto_tracking");

            builder.HasNoKey();

            builder.Property(e => e.ArticuloId)
                .HasColumnName("articulo_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ContentType)
                .HasColumnName("content_type")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.NombreArchivo)
                .HasColumnName("nombre_archivo")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Content)
                .HasColumnName("content")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}
