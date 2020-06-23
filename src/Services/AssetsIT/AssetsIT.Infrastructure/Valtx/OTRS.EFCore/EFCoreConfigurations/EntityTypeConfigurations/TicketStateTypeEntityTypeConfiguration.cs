using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    class TicketStateTypeEntityTypeConfiguration : IEntityTypeConfiguration<TicketState>
    {
        public void Configure(EntityTypeBuilder<TicketState> builder)
        {
            builder.ToTable("ticket_state");

            builder.HasIndex(e => e.ChangeBy)
                .HasName("FK_ticket_state_change_by_id");

            builder.HasIndex(e => e.CreateBy)
                .HasName("FK_ticket_state_create_by_id");

            builder.HasIndex(e => e.Name)
                .HasName("ticket_state_name")
                .IsUnique();

            builder.HasIndex(e => e.TypeId)
                .HasName("FK_ticket_state_type_id_id");

            builder.HasIndex(e => e.ValidId)
                .HasName("FK_ticket_state_valid_id_id");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("smallint(6)");

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

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TypeId)
                .HasColumnName("type_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.ValidId)
                .HasColumnName("valid_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.NameSpn)
                .IsRequired()
                .HasColumnName("name_spn")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}
