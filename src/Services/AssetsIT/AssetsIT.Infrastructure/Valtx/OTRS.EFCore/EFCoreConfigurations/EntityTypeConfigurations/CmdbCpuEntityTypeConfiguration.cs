using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class CmdbCpuEntityTypeConfiguration : IEntityTypeConfiguration<CmdbCpu>
    {
        public void Configure(EntityTypeBuilder<CmdbCpu> builder) {
            builder.ToTable("cmdb_cpu");

            builder.HasIndex(e => e.Id)
                .HasName("id")
                .IsUnique();

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ActivationDate)
                .HasColumnName("activation_date")
                .HasColumnType("date");

            builder.Property(e => e.Anexo)
                .IsRequired()
                .HasColumnName("anexo")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.CableSeg)
                .IsRequired()
                .HasColumnName("cable_seg")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Cargador)
                .IsRequired()
                .HasColumnName("cargador")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Comentario)
                .IsRequired()
                .HasColumnName("comentario")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ContratoMarco)
                .IsRequired()
                .HasColumnName("contrato_marco")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Cpu)
                .IsRequired()
                .HasColumnName("cpu")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.DeploymentState)
                .IsRequired()
                .HasColumnName("deployment_state")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.DirPropNow)
                .HasColumnName("dir_prop_now")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.DirPropietario)
                .IsRequired()
                .HasColumnName("dir_propietario")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Disco)
                .IsRequired()
                .HasColumnName("disco")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Disquetera)
                .IsRequired()
                .HasColumnName("disquetera")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.EstadoAnexo)
                .IsRequired()
                .HasColumnName("estado_anexo")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.EstadoEquipo)
                .IsRequired()
                .HasColumnName("estado_equipo")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Fabricante)
                .IsRequired()
                .HasColumnName("fabricante")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.FechaCompra)
                .HasColumnName("fecha_compra")
                .HasColumnType("date");

            builder.Property(e => e.FechaDev)
                .HasColumnName("fecha_dev")
                .HasColumnType("date");

            builder.Property(e => e.FechaGarantia)
                .HasColumnName("fecha_garantia")
                .HasColumnType("date");

            builder.Property(e => e.FechaMod)
                .HasColumnName("fecha_mod")
                .HasColumnType("date");

            builder.Property(e => e.FechaRecepcion)
                .HasColumnName("fecha_recepcion")
                .HasColumnType("date");

            builder.Property(e => e.GarComercial)
                .IsRequired()
                .HasColumnName("gar_comercial")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.GarSoporte)
                .IsRequired()
                .HasColumnName("gar_soporte")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.GerPropNow)
                .HasColumnName("ger_prop_now")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.GerPropietario)
                .IsRequired()
                .HasColumnName("ger_propietario")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.IncidentState)
                .IsRequired()
                .HasColumnName("incident_state")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.JefPropNow)
                .HasColumnName("jef_prop_now")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.JefPropietario)
                .IsRequired()
                .HasColumnName("jef_propietario")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.LectExterno)
                .IsRequired()
                .HasColumnName("lect_externo")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Lectora)
                .IsRequired()
                .HasColumnName("lectora")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.LectoraGrab)
                .IsRequired()
                .HasColumnName("lectora_grab")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Local)
                .IsRequired()
                .HasColumnName("local")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Maletin)
                .IsRequired()
                .HasColumnName("maletin")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Modelo)
                .IsRequired()
                .HasColumnName("modelo")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Mouse)
                .IsRequired()
                .HasColumnName("mouse")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.NegPropNow)
                .HasColumnName("neg_prop_now")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.NegPropietario)
                .IsRequired()
                .HasColumnName("neg_propietario")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Note)
                .IsRequired()
                .HasColumnName("note")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.OrdenCompra)
                .IsRequired()
                .HasColumnName("orden_compra")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Owner)
                .IsRequired()
                .HasColumnName("owner")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Precio)
                .IsRequired()
                .HasColumnName("precio")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Proveedor)
                .IsRequired()
                .HasColumnName("proveedor")
                .HasColumnType("varchar(200)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Ram)
                .IsRequired()
                .HasColumnName("ram")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Serie)
                .IsRequired()
                .HasColumnName("serie")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.SistemaOper)
                .IsRequired()
                .HasColumnName("sistema_oper")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Solpe)
                .IsRequired()
                .HasColumnName("solpe")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Teclado)
                .IsRequired()
                .HasColumnName("teclado")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TipoMon)
                .IsRequired()
                .HasColumnName("tipo_mon")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TipoPropiedad)
                .IsRequired()
                .HasColumnName("tipo_propiedad")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Ubicacion)
                .IsRequired()
                .HasColumnName("ubicacion")
                .HasColumnType("varchar(100)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Zonal)
                .IsRequired()
                .HasColumnName("zonal")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");
        }
    }
}