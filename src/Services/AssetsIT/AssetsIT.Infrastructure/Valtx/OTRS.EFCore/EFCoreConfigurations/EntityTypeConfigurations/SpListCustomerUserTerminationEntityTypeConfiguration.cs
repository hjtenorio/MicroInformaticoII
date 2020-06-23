using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    class SpListCustomerUserTerminationEntityTypeConfiguration : IEntityTypeConfiguration<SpListUserCese>
    {
        public void Configure(EntityTypeBuilder<SpListUserCese> builder)
        {
            builder.ToView("sp_list_user_cese");

            builder.HasNoKey();

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.CustomerId)
                .IsRequired()
                .HasColumnName("customer_id")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Dni)
                .HasColumnName("dni")
                .HasColumnType("varchar(64)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TerminationDate)
                .HasColumnName("TerminationDate");

            builder.Property(e => e.RenewalDate)
                .HasColumnName("RenewalDate");
        }
    }
}
