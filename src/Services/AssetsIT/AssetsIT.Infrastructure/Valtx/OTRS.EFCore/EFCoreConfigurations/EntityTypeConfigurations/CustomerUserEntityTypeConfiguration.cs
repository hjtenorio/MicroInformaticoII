using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class CustomerUserEntityTypeConfiguration : IEntityTypeConfiguration<CustomerUser>
    {
        public void Configure(EntityTypeBuilder<CustomerUser> builder) {
            builder.ToTable("customer_user");

            builder.HasIndex(e => e.ChangeBy)
                .HasName("FK_customer_user_change_by_id");

            builder.HasIndex(e => e.CreateBy)
                .HasName("FK_customer_user_create_by_id");

            builder.HasIndex(e => e.Login)
                .HasName("customer_user_login")
                .IsUnique();

            builder.HasIndex(e => e.ValidId)
                .HasName("FK_customer_user_valid_id_id");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)");

            builder.Property(e => e.Cargo)
                .HasColumnName("cargo")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ChangeBy)
                .HasColumnName("change_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChangeTime).HasColumnName("change_time");

            builder.Property(e => e.CipJefeInmediato)
                .HasColumnName("cip_jefe_inmediato")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.City)
                .HasColumnName("city")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Comments)
                .HasColumnName("comments")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            //builder.Property(e => e.Contrata)
            //    .HasColumnName("contrata")
            //    .HasColumnType("int(1)");

            builder.Property(e => e.Country)
                .HasColumnName("country")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.CreateTime).HasColumnName("create_time");

            builder.Property(e => e.CustomerId)
                .IsRequired()
                .HasColumnName("customer_id")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            //builder.Property(e => e.DateFinLic)
            //    .HasColumnName("date_fin_lic")
            //    .HasColumnType("varchar(50)")
            //    .HasCharSet("utf8")
            //    .HasCollation("utf8_general_ci");

            //builder.Property(e => e.DateIniLic)
            //    .HasColumnName("date_ini_lic")
            //    .HasColumnType("varchar(50)")
            //    .HasCharSet("utf8")
            //    .HasCollation("utf8_general_ci");

            builder.Property(e => e.Departamento)
                .HasColumnName("departamento")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Directo)
                .HasColumnName("directo")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Dni)
                .HasColumnName("dni")
                .HasColumnType("varchar(64)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Empresa)
                .HasColumnName("empresa")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Empresa2)
                .HasColumnName("empresa2")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Fax)
                .HasColumnName("fax")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("first_name")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Gerencia)
                .HasColumnName("gerencia")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            //builder.Property(e => e.IdTipoLic)
            //    .HasColumnName("id_tipo_lic")
            //    .HasColumnType("int(11)");

            builder.Property(e => e.Jefatura)
                .HasColumnName("jefatura")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Jefe)
                .HasColumnName("jefe")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.JefeInmediato)
                .HasColumnName("jefe_inmediato")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("last_name")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Login)
                .IsRequired()
                .HasColumnName("login")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Mobile)
                .HasColumnName("mobile")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Phone)
                .HasColumnName("phone")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Pw)
                .HasColumnName("pw")
                .HasColumnType("varchar(64)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Rpm)
                .HasColumnName("rpm")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Sigla)
                .HasColumnName("sigla")
                .HasColumnType("varchar(30)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Street)
                .HasColumnName("street")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Supervision)
                .HasColumnName("supervision")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Title)
                .HasColumnName("title")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ValidId)
                .HasColumnName("valid_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.Zip)
                .HasColumnName("zip")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.DateEndcontrat).HasColumnName("date_endcontrat");

            builder.Property(e => e.DateCessation).HasColumnName("date_cessation");

            builder.Property(e => e.FlagDevolEquipo)
            .HasColumnName("flag_devolequipo")
            .HasColumnType("smallint(3)");
        }
    }
}