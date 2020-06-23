using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class TicketTypeEntityTypeConfiguration : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.ToTable("ticket_type");

            builder.HasIndex(e => e.ChangeBy)
                .HasName("FK_ticket_type_change_by_id");

            builder.HasIndex(e => e.CreateBy)
                .HasName("FK_ticket_type_create_by_id");

            builder.HasIndex(e => e.Name)
                .HasName("ticket_type_name")
                .IsUnique();

            builder.HasIndex(e => e.ValidId)
                .HasName("FK_ticket_type_valid_id_id");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.ChangeBy)
                .HasColumnName("change_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChangeTime).HasColumnName("change_time");

            builder.Property(e => e.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.CreateTime).HasColumnName("create_time");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ValidId)
                .HasColumnName("valid_id")
                .HasColumnType("smallint(6)");
        }
    }
}
