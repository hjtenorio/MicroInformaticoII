using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class ServiceEntityTypeConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("service");

            builder.HasIndex(e => e.ChangeBy)
                .HasName("FK_service_change_by_id");

            builder.HasIndex(e => e.CreateBy)
                .HasName("FK_service_create_by_id");

            builder.HasIndex(e => e.Name)
                .HasName("service_name")
                .IsUnique();

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChangeBy)
                .HasColumnName("change_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChangeTime).HasColumnName("change_time");

            builder.Property(e => e.Comments)
                .HasColumnName("comments")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.CreateTime).HasColumnName("create_time");

            builder.Property(e => e.Criticality)
                .HasColumnName("criticality")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TypeId)
                .HasColumnName("type_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ValidId)
                .HasColumnName("valid_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.TypeService)
                .HasColumnName("type_service")
                .HasColumnType("varchar(1)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}
