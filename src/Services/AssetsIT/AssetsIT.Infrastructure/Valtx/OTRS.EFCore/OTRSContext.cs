using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations;
using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore
{
    public class OTRSContext : DbContext
    {
        public OTRSContext()
        { 
        }

        public OTRSContext(DbContextOptions<OTRSContext> options) : base(options) {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new ArticleEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CmdbCpuEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerUserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TicketEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TicketTypeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VwServiceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SpQueueTrackingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SpQueueDetailTrackingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SpQueueDetailAttachmentsTrackingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SpListTicketByUserTrackingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TicketStateTypeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SpListCustomerUserTerminationEntityTypeConfiguration());
        }

        //Tables
        public DbSet<Article> Article { get; set; }
        public DbSet<CmdbCpu> CmdbCpu { get; set; }
        public DbSet<CustomerUser> CustomerUser { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<TicketState> TicketState { get; set; }
        //Views
        public DbSet<VwService> VwService { get; set; }
        //Stored Procedure
        public DbSet<SpCabeceraTracking> SpCabeceraTracking { get; set; }
        public DbSet<SpDetalleTracking> SpDetalleTracking { get; set; }
        public DbSet<SpDetalleAdjuntosTracking> SpDetalleAdjuntosTracking { get; set; }
        public DbSet<SpListTicketsByUser> SpListTicketsByUser { get; set; }
        public DbSet<SpListUserCese> SpListUserCese { get; set; }
    }
}