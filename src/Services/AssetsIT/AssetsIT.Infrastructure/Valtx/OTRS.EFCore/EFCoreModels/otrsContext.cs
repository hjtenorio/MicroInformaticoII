using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Valtx
{
    public partial class otrsContext : DbContext
    {
        public otrsContext()
        {
        }

        public otrsContext(DbContextOptions<otrsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acl> Acl { get; set; }
        public virtual DbSet<AclSync> AclSync { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleAttachment> ArticleAttachment { get; set; }
        public virtual DbSet<ArticleFlag> ArticleFlag { get; set; }
        public virtual DbSet<ArticlePlain> ArticlePlain { get; set; }
        public virtual DbSet<ArticleSearch> ArticleSearch { get; set; }
        public virtual DbSet<ArticleSenderType> ArticleSenderType { get; set; }
        public virtual DbSet<ArticleType> ArticleType { get; set; }
        public virtual DbSet<AutoResponse> AutoResponse { get; set; }
        public virtual DbSet<AutoResponseType> AutoResponseType { get; set; }
        public virtual DbSet<ChangeCab> ChangeCab { get; set; }
        public virtual DbSet<ChangeCipAllocate> ChangeCipAllocate { get; set; }
        public virtual DbSet<ChangeCondition> ChangeCondition { get; set; }
        public virtual DbSet<ChangeHistory> ChangeHistory { get; set; }
        public virtual DbSet<ChangeHistoryType> ChangeHistoryType { get; set; }
        public virtual DbSet<ChangeItem> ChangeItem { get; set; }
        public virtual DbSet<ChangeNotification> ChangeNotification { get; set; }
        public virtual DbSet<ChangeNotificationGrps> ChangeNotificationGrps { get; set; }
        public virtual DbSet<ChangeNotificationRec> ChangeNotificationRec { get; set; }
        public virtual DbSet<ChangeStateMachine> ChangeStateMachine { get; set; }
        public virtual DbSet<ChangeTemplate> ChangeTemplate { get; set; }
        public virtual DbSet<ChangeTemplateType> ChangeTemplateType { get; set; }
        public virtual DbSet<ChangeWorkorder> ChangeWorkorder { get; set; }
        public virtual DbSet<CipAllocate> CipAllocate { get; set; }
        public virtual DbSet<CmdbCpu> CmdbCpu { get; set; }
        public virtual DbSet<CmdbCpuHist> CmdbCpuHist { get; set; }
        public virtual DbSet<CmdbLicencia> CmdbLicencia { get; set; }
        public virtual DbSet<CmdbMonPer> CmdbMonPer { get; set; }
        public virtual DbSet<CmdbMonPerHist> CmdbMonPerHist { get; set; }
        public virtual DbSet<CmdbMoviles> CmdbMoviles { get; set; }
        public virtual DbSet<ConditionAction> ConditionAction { get; set; }
        public virtual DbSet<ConditionAttribute> ConditionAttribute { get; set; }
        public virtual DbSet<ConditionExpression> ConditionExpression { get; set; }
        public virtual DbSet<ConditionObject> ConditionObject { get; set; }
        public virtual DbSet<ConditionOperator> ConditionOperator { get; set; }
        public virtual DbSet<Configitem> Configitem { get; set; }
        public virtual DbSet<ConfigitemCounter> ConfigitemCounter { get; set; }
        public virtual DbSet<ConfigitemDefinition> ConfigitemDefinition { get; set; }
        public virtual DbSet<ConfigitemHistory> ConfigitemHistory { get; set; }
        public virtual DbSet<ConfigitemHistoryType> ConfigitemHistoryType { get; set; }
        public virtual DbSet<ConfigitemVersion> ConfigitemVersion { get; set; }
        public virtual DbSet<CustomerCompany> CustomerCompany { get; set; }
        public virtual DbSet<CustomerPreferences> CustomerPreferences { get; set; }
        public virtual DbSet<CustomerUser> CustomerUser { get; set; }
        public virtual DbSet<CustomerUserInter> CustomerUserInter { get; set; }
        public virtual DbSet<CustomerUserRaw> CustomerUserRaw { get; set; }
        public virtual DbSet<CustomerUserTmp> CustomerUserTmp { get; set; }
        public virtual DbSet<DynamicField> DynamicField { get; set; }
        public virtual DbSet<DynamicFieldValue> DynamicFieldValue { get; set; }
        public virtual DbSet<FaqAttachment> FaqAttachment { get; set; }
        public virtual DbSet<FaqCategory> FaqCategory { get; set; }
        public virtual DbSet<FaqCategoryGroup> FaqCategoryGroup { get; set; }
        public virtual DbSet<FaqHistory> FaqHistory { get; set; }
        public virtual DbSet<FaqItem> FaqItem { get; set; }
        public virtual DbSet<FaqLanguage> FaqLanguage { get; set; }
        public virtual DbSet<FaqLog> FaqLog { get; set; }
        public virtual DbSet<FaqState> FaqState { get; set; }
        public virtual DbSet<FaqStateType> FaqStateType { get; set; }
        public virtual DbSet<FaqVoting> FaqVoting { get; set; }
        public virtual DbSet<FollowUpPossible> FollowUpPossible { get; set; }
        public virtual DbSet<GeneralCatalog> GeneralCatalog { get; set; }
        public virtual DbSet<GeneralCatalogPreferences> GeneralCatalogPreferences { get; set; }
        public virtual DbSet<GenericAgentJobs> GenericAgentJobs { get; set; }
        public virtual DbSet<GiDebuggerEntry> GiDebuggerEntry { get; set; }
        public virtual DbSet<GiDebuggerEntryContent> GiDebuggerEntryContent { get; set; }
        public virtual DbSet<GiObjectLockState> GiObjectLockState { get; set; }
        public virtual DbSet<GiWebserviceConfig> GiWebserviceConfig { get; set; }
        public virtual DbSet<GiWebserviceConfigHistory> GiWebserviceConfigHistory { get; set; }
        public virtual DbSet<GrepContrata> GrepContrata { get; set; }
        public virtual DbSet<GrepCtaRedSolMoviles> GrepCtaRedSolMoviles { get; set; }
        public virtual DbSet<GrepDGuia> GrepDGuia { get; set; }
        public virtual DbSet<GrepFichaSolMoviles> GrepFichaSolMoviles { get; set; }
        public virtual DbSet<GrepMGuia> GrepMGuia { get; set; }
        public virtual DbSet<GrepParametro> GrepParametro { get; set; }
        public virtual DbSet<GrepParametrovalor> GrepParametrovalor { get; set; }
        public virtual DbSet<GrepSolicitud> GrepSolicitud { get; set; }
        public virtual DbSet<GrepSolicitudrecurso> GrepSolicitudrecurso { get; set; }
        public virtual DbSet<GrepSolicitudrequerimiento> GrepSolicitudrequerimiento { get; set; }
        public virtual DbSet<GrepTiporequerimiento> GrepTiporequerimiento { get; set; }
        public virtual DbSet<GrepTiporequerimientoSubtipos> GrepTiporequerimientoSubtipos { get; set; }
        public virtual DbSet<GrepTipreqCombina> GrepTipreqCombina { get; set; }
        public virtual DbSet<GrepUsuarioautorizador> GrepUsuarioautorizador { get; set; }
        public virtual DbSet<GroupCustomerUser> GroupCustomerUser { get; set; }
        public virtual DbSet<GroupRole> GroupRole { get; set; }
        public virtual DbSet<GroupUser> GroupUser { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<ImexportFormat> ImexportFormat { get; set; }
        public virtual DbSet<ImexportMapping> ImexportMapping { get; set; }
        public virtual DbSet<ImexportMappingFormat> ImexportMappingFormat { get; set; }
        public virtual DbSet<ImexportMappingObject> ImexportMappingObject { get; set; }
        public virtual DbSet<ImexportObject> ImexportObject { get; set; }
        public virtual DbSet<ImexportSearch> ImexportSearch { get; set; }
        public virtual DbSet<ImexportTemplate> ImexportTemplate { get; set; }
        public virtual DbSet<LinkObject> LinkObject { get; set; }
        public virtual DbSet<LinkRelation> LinkRelation { get; set; }
        public virtual DbSet<LinkState> LinkState { get; set; }
        public virtual DbSet<LinkType> LinkType { get; set; }
        public virtual DbSet<MailAccount> MailAccount { get; set; }
        public virtual DbSet<NotificationEvent> NotificationEvent { get; set; }
        public virtual DbSet<NotificationEventItem> NotificationEventItem { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OtrsTk> OtrsTk { get; set; }
        public virtual DbSet<PackageRepository> PackageRepository { get; set; }
        public virtual DbSet<PersonalQueues> PersonalQueues { get; set; }
        public virtual DbSet<PersonalServices> PersonalServices { get; set; }
        public virtual DbSet<PmActivity> PmActivity { get; set; }
        public virtual DbSet<PmActivityDialog> PmActivityDialog { get; set; }
        public virtual DbSet<PmEntitySync> PmEntitySync { get; set; }
        public virtual DbSet<PmProcess> PmProcess { get; set; }
        public virtual DbSet<PmTransition> PmTransition { get; set; }
        public virtual DbSet<PmTransitionAction> PmTransitionAction { get; set; }
        public virtual DbSet<PostmasterFilter> PostmasterFilter { get; set; }
        public virtual DbSet<ProcessId> ProcessId { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<QueueAutoResponse> QueueAutoResponse { get; set; }
        public virtual DbSet<QueuePreferences> QueuePreferences { get; set; }
        public virtual DbSet<QueueStandardTemplate> QueueStandardTemplate { get; set; }
        public virtual DbSet<RoleUser> RoleUser { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Salutation> Salutation { get; set; }
        public virtual DbSet<SchedulerTaskList> SchedulerTaskList { get; set; }
        public virtual DbSet<SearchProfile> SearchProfile { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceCustomerUser> ServiceCustomerUser { get; set; }
        public virtual DbSet<ServicePreferences> ServicePreferences { get; set; }
        public virtual DbSet<ServiceSla> ServiceSla { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Signature> Signature { get; set; }
        public virtual DbSet<Sla> Sla { get; set; }
        public virtual DbSet<SlaPreferences> SlaPreferences { get; set; }
        public virtual DbSet<SmFeriados> SmFeriados { get; set; }
        public virtual DbSet<SmHorario> SmHorario { get; set; }
        public virtual DbSet<SmOperaciones> SmOperaciones { get; set; }
        public virtual DbSet<SmPreoperaciones> SmPreoperaciones { get; set; }
        public virtual DbSet<SmServicios> SmServicios { get; set; }
        public virtual DbSet<SmTorre> SmTorre { get; set; }
        public virtual DbSet<SmimeSignerCertRelations> SmimeSignerCertRelations { get; set; }
        public virtual DbSet<StandardAttachment> StandardAttachment { get; set; }
        public virtual DbSet<StandardTemplate> StandardTemplate { get; set; }
        public virtual DbSet<StandardTemplateAttachment> StandardTemplateAttachment { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyAnswer> SurveyAnswer { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public virtual DbSet<SurveyQueue> SurveyQueue { get; set; }
        public virtual DbSet<SurveyRequest> SurveyRequest { get; set; }
        public virtual DbSet<SurveyVote> SurveyVote { get; set; }
        public virtual DbSet<SystemAddress> SystemAddress { get; set; }
        public virtual DbSet<SystemData> SystemData { get; set; }
        public virtual DbSet<SystemMaintenance> SystemMaintenance { get; set; }
        public virtual DbSet<TiReportAtenciones> TiReportAtenciones { get; set; }
        public virtual DbSet<TiReportFlujoHistorial> TiReportFlujoHistorial { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketFlag> TicketFlag { get; set; }
        public virtual DbSet<TicketHistory> TicketHistory { get; set; }
        public virtual DbSet<TicketHistoryType> TicketHistoryType { get; set; }
        public virtual DbSet<TicketIndex> TicketIndex { get; set; }
        public virtual DbSet<TicketLockIndex> TicketLockIndex { get; set; }
        public virtual DbSet<TicketLockType> TicketLockType { get; set; }
        public virtual DbSet<TicketLoopProtection> TicketLoopProtection { get; set; }
        public virtual DbSet<TicketPriority> TicketPriority { get; set; }
        public virtual DbSet<TicketState> TicketState { get; set; }
        public virtual DbSet<TicketStateType> TicketStateType { get; set; }
        public virtual DbSet<TicketType> TicketType { get; set; }
        public virtual DbSet<TicketWatcher> TicketWatcher { get; set; }
        public virtual DbSet<TimeAccounting> TimeAccounting { get; set; }
        public virtual DbSet<TimeAccountingAction> TimeAccountingAction { get; set; }
        public virtual DbSet<TimeAccountingProject> TimeAccountingProject { get; set; }
        public virtual DbSet<TimeAccountingTable> TimeAccountingTable { get; set; }
        public virtual DbSet<TimeAccountingUser> TimeAccountingUser { get; set; }
        public virtual DbSet<TimeAccountingUserPeriod> TimeAccountingUserPeriod { get; set; }
        public virtual DbSet<UserPreferences> UserPreferences { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Valid> Valid { get; set; }
        public virtual DbSet<VirtualFs> VirtualFs { get; set; }
        public virtual DbSet<VirtualFsDb> VirtualFsDb { get; set; }
        public virtual DbSet<VirtualFsPreferences> VirtualFsPreferences { get; set; }
        public virtual DbSet<VwOtrsToLs> VwOtrsToLs { get; set; }
        public virtual DbSet<WebUploadCache> WebUploadCache { get; set; }
        public virtual DbSet<WpLicencias> WpLicencias { get; set; }
        public virtual DbSet<WpReportOtrs> WpReportOtrs { get; set; }
        public virtual DbSet<XmlStorage> XmlStorage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("data source=172.13.33.107;initial catalog=otrs;uid=micro;pwd=tgestiona", x => x.ServerVersion("5.5.60-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acl>(entity =>
            {
                entity.ToTable("acl");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_acl_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_acl_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("acl_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_acl_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConfigChange).HasColumnName("config_change");

                entity.Property(e => e.ConfigMatch).HasColumnName("config_match");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StopAfterMatch)
                    .HasColumnName("stop_after_match")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<AclSync>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acl_sync");

                entity.Property(e => e.AclId)
                    .IsRequired()
                    .HasColumnName("acl_id")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.SyncState)
                    .IsRequired()
                    .HasColumnName("sync_state")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("article");

                entity.HasIndex(e => e.AMessageIdMd5)
                    .HasName("article_message_id_md5");

                entity.HasIndex(e => e.ArticleSenderTypeId)
                    .HasName("article_article_sender_type_id");

                entity.HasIndex(e => e.ArticleTypeId)
                    .HasName("article_article_type_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_article_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_article_create_by_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("article_ticket_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_article_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ABody)
                    .IsRequired()
                    .HasColumnName("a_body")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ACc)
                    .HasColumnName("a_cc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AContentType)
                    .HasColumnName("a_content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AFrom)
                    .HasColumnName("a_from")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AInReplyTo)
                    .HasColumnName("a_in_reply_to")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AMessageId)
                    .HasColumnName("a_message_id")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AMessageIdMd5)
                    .HasColumnName("a_message_id_md5")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AReferences)
                    .HasColumnName("a_references")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AReplyTo)
                    .HasColumnName("a_reply_to")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ASubject)
                    .HasColumnName("a_subject")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ATo)
                    .HasColumnName("a_to")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ArticleSenderTypeId)
                    .HasColumnName("article_sender_type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ArticleTypeId)
                    .HasColumnName("article_type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.ContentPath)
                    .HasColumnName("content_path")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.IncomingTime)
                    .HasColumnName("incoming_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ArticleAttachment>(entity =>
            {
                entity.ToTable("article_attachment");

                entity.HasIndex(e => e.ArticleId)
                    .HasName("article_attachment_article_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_article_attachment_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_article_attachment_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.ContentAlternative)
                    .HasColumnName("content_alternative")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentId)
                    .HasColumnName("content_id")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentSize)
                    .HasColumnName("content_size")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Disposition)
                    .HasColumnName("disposition")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ArticleFlag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("article_flag");

                entity.HasIndex(e => e.ArticleId)
                    .HasName("article_flag_article_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_article_flag_create_by_id");

                entity.HasIndex(e => new { e.ArticleId, e.CreateBy })
                    .HasName("article_flag_article_id_create_by");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArticleKey)
                    .IsRequired()
                    .HasColumnName("article_key")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ArticleValue)
                    .HasColumnName("article_value")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");
            });

            modelBuilder.Entity<ArticlePlain>(entity =>
            {
                entity.ToTable("article_plain");

                entity.HasIndex(e => e.ArticleId)
                    .HasName("article_plain_article_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_article_plain_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_article_plain_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");
            });

            modelBuilder.Entity<ArticleSearch>(entity =>
            {
                entity.ToTable("article_search");

                entity.HasIndex(e => e.ArticleSenderTypeId)
                    .HasName("article_search_article_sender_type_id");

                entity.HasIndex(e => e.ArticleTypeId)
                    .HasName("article_search_article_type_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("article_search_ticket_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ABody)
                    .IsRequired()
                    .HasColumnName("a_body")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ACc)
                    .HasColumnName("a_cc")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AFrom)
                    .HasColumnName("a_from")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ASubject)
                    .HasColumnName("a_subject")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ATo)
                    .HasColumnName("a_to")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ArticleSenderTypeId)
                    .HasColumnName("article_sender_type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ArticleTypeId)
                    .HasColumnName("article_type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.IncomingTime)
                    .HasColumnName("incoming_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ArticleSenderType>(entity =>
            {
                entity.ToTable("article_sender_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_article_sender_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_article_sender_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("article_sender_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_article_sender_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ArticleType>(entity =>
            {
                entity.ToTable("article_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_article_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_article_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("article_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_article_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<AutoResponse>(entity =>
            {
                entity.ToTable("auto_response");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_auto_response_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_auto_response_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("auto_response_name")
                    .IsUnique();

                entity.HasIndex(e => e.SystemAddressId)
                    .HasName("FK_auto_response_system_address_id_id");

                entity.HasIndex(e => e.TypeId)
                    .HasName("FK_auto_response_type_id_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_auto_response_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Charset)
                    .IsRequired()
                    .HasColumnName("charset")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SystemAddressId)
                    .HasColumnName("system_address_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Text0)
                    .HasColumnName("text0")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text1)
                    .HasColumnName("text1")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text2)
                    .HasColumnName("text2")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<AutoResponseType>(entity =>
            {
                entity.ToTable("auto_response_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_auto_response_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_auto_response_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("auto_response_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_auto_response_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ChangeCab>(entity =>
            {
                entity.ToTable("change_cab");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_change_cab_user_id_id");

                entity.HasIndex(e => new { e.ChangeId, e.UserId, e.CustomerUserId })
                    .HasName("change_cab_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("change_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CustomerUserId)
                    .HasColumnName("customer_user_id")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChangeCipAllocate>(entity =>
            {
                entity.ToTable("change_cip_allocate");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_change_cip_allocate_category_id_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_change_cip_allocate_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_change_cip_allocate_create_by_id");

                entity.HasIndex(e => e.ImpactId)
                    .HasName("FK_change_cip_allocate_impact_id_id");

                entity.HasIndex(e => e.PriorityId)
                    .HasName("FK_change_cip_allocate_priority_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.ImpactId)
                    .HasColumnName("impact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PriorityId)
                    .HasColumnName("priority_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChangeCondition>(entity =>
            {
                entity.ToTable("change_condition");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_change_condition_change_by_id");

                entity.HasIndex(e => e.ChangeId)
                    .HasName("change_condition_change_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_change_condition_create_by_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("change_condition_valid_id");

                entity.HasIndex(e => new { e.ChangeId, e.Name })
                    .HasName("condition_condition_change_id_name_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("change_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.ExpressionConjunction)
                    .IsRequired()
                    .HasColumnName("expression_conjunction")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ChangeHistory>(entity =>
            {
                entity.ToTable("change_history");

                entity.HasIndex(e => e.ChangeId)
                    .HasName("change_history_change_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_change_history_create_by_id");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("change_history_create_time");

                entity.HasIndex(e => e.TypeId)
                    .HasName("change_history_type_id");

                entity.HasIndex(e => e.WorkorderId)
                    .HasName("change_history_workorder_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("change_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ContentNew)
                    .HasColumnName("content_new")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentOld)
                    .HasColumnName("content_old")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Fieldname)
                    .HasColumnName("fieldname")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkorderId)
                    .HasColumnName("workorder_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ChangeHistoryType>(entity =>
            {
                entity.ToTable("change_history_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_change_history_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_change_history_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("change_history_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("change_history_type_valid_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ChangeItem>(entity =>
            {
                entity.ToTable("change_item");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("change_item_category_id");

                entity.HasIndex(e => e.ChangeBuilderId)
                    .HasName("change_item_change_builder_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_change_item_change_by_id");

                entity.HasIndex(e => e.ChangeManagerId)
                    .HasName("change_item_change_manager_id");

                entity.HasIndex(e => e.ChangeNumber)
                    .HasName("change_item_change_number")
                    .IsUnique();

                entity.HasIndex(e => e.ChangeStateId)
                    .HasName("change_item_change_state_id");

                entity.HasIndex(e => e.ChangeTime)
                    .HasName("change_item_change_time");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_change_item_create_by_id");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("change_item_create_time");

                entity.HasIndex(e => e.ImpactId)
                    .HasName("change_item_impact_id");

                entity.HasIndex(e => e.PriorityId)
                    .HasName("change_item_priority_id");

                entity.HasIndex(e => e.RequestedTime)
                    .HasName("change_item_requested_time");

                entity.HasIndex(e => e.Title)
                    .HasName("change_item_title");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBuilderId)
                    .HasColumnName("change_builder_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeManagerId)
                    .HasColumnName("change_manager_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeNumber)
                    .IsRequired()
                    .HasColumnName("change_number")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeStateId)
                    .HasColumnName("change_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DescriptionPlain)
                    .HasColumnName("description_plain")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImpactId)
                    .HasColumnName("impact_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Justification)
                    .HasColumnName("justification")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JustificationPlain)
                    .HasColumnName("justification_plain")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PriorityId)
                    .HasColumnName("priority_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RequestedTime).HasColumnName("requested_time");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ChangeNotification>(entity =>
            {
                entity.ToTable("change_notification");

                entity.HasIndex(e => e.EventId)
                    .HasName("change_notification_event_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("change_notification_valid_id");

                entity.HasIndex(e => new { e.EventId, e.ValidId })
                    .HasName("change_notification_event_valid_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemAttribute)
                    .HasColumnName("item_attribute")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationRule)
                    .HasColumnName("notification_rule")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ChangeNotificationGrps>(entity =>
            {
                entity.ToTable("change_notification_grps");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ChangeNotificationRec>(entity =>
            {
                entity.ToTable("change_notification_rec");

                entity.HasIndex(e => e.GroupId)
                    .HasName("change_notification_rec_group_id");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("change_notification_rec_notification_id");

                entity.HasIndex(e => new { e.GroupId, e.NotificationId })
                    .HasName("change_notification_rec_group_notification");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notification_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ChangeStateMachine>(entity =>
            {
                entity.ToTable("change_state_machine");

                entity.HasIndex(e => new { e.StateId, e.NextStateId })
                    .HasName("change_state_machine_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NextStateId)
                    .HasColumnName("next_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChangeTemplate>(entity =>
            {
                entity.ToTable("change_template");

                entity.HasIndex(e => e.TypeId)
                    .HasName("change_template_type_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("change_template_valid_id");

                entity.HasIndex(e => new { e.Name, e.TypeId })
                    .HasName("change_template_name_type_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ChangeTemplateType>(entity =>
            {
                entity.ToTable("change_template_type");

                entity.HasIndex(e => e.Name)
                    .HasName("change_template_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("change_template_type_valid_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ChangeWorkorder>(entity =>
            {
                entity.ToTable("change_workorder");

                entity.HasIndex(e => e.ActualEndTime)
                    .HasName("change_workorder_actual_end_time");

                entity.HasIndex(e => e.ActualStartTime)
                    .HasName("change_workorder_actual_start_time");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_change_workorder_change_by_id");

                entity.HasIndex(e => e.ChangeId)
                    .HasName("change_workorder_change_id");

                entity.HasIndex(e => e.ChangeTime)
                    .HasName("change_workorder_change_time");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_change_workorder_create_by_id");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("change_workorder_create_time");

                entity.HasIndex(e => e.PlannedEndTime)
                    .HasName("change_workorder_planned_end_time");

                entity.HasIndex(e => e.PlannedStartTime)
                    .HasName("change_workorder_planned_start_time");

                entity.HasIndex(e => e.Title)
                    .HasName("change_workorder_title");

                entity.HasIndex(e => e.WorkorderAgentId)
                    .HasName("change_workorder_workorder_agent_id");

                entity.HasIndex(e => e.WorkorderStateId)
                    .HasName("change_workorder_workorder_state_id");

                entity.HasIndex(e => e.WorkorderTypeId)
                    .HasName("change_workorder_workorder_type_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AccountedTime)
                    .HasColumnName("accounted_time")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ActualEndTime)
                    .HasColumnName("actual_end_time")
                    .HasDefaultValueSql("'9999-01-01 00:00:00'");

                entity.Property(e => e.ActualStartTime)
                    .HasColumnName("actual_start_time")
                    .HasDefaultValueSql("'9999-01-01 00:00:00'");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeId)
                    .HasColumnName("change_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Instruction)
                    .HasColumnName("instruction")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InstructionPlain)
                    .HasColumnName("instruction_plain")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlannedEffort)
                    .HasColumnName("planned_effort")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PlannedEndTime)
                    .HasColumnName("planned_end_time")
                    .HasDefaultValueSql("'9999-01-01 00:00:00'");

                entity.Property(e => e.PlannedStartTime)
                    .HasColumnName("planned_start_time")
                    .HasDefaultValueSql("'9999-01-01 00:00:00'");

                entity.Property(e => e.Report)
                    .HasColumnName("report")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReportPlain)
                    .HasColumnName("report_plain")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkorderAgentId)
                    .HasColumnName("workorder_agent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkorderNumber)
                    .HasColumnName("workorder_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkorderStateId)
                    .HasColumnName("workorder_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkorderTypeId)
                    .HasColumnName("workorder_type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CipAllocate>(entity =>
            {
                entity.ToTable("cip_allocate");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_cip_allocate_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_cip_allocate_create_by_id");

                entity.HasIndex(e => e.PriorityId)
                    .HasName("FK_cip_allocate_priority_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Criticality)
                    .IsRequired()
                    .HasColumnName("criticality")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Impact)
                    .IsRequired()
                    .HasColumnName("impact")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PriorityId)
                    .HasColumnName("priority_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<CmdbCpu>(entity =>
            {
                entity.ToTable("cmdb_cpu");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActivationDate)
                    .HasColumnName("activation_date")
                    .HasColumnType("date");

                entity.Property(e => e.Anexo)
                    .IsRequired()
                    .HasColumnName("anexo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CableSeg)
                    .IsRequired()
                    .HasColumnName("cable_seg")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cargador)
                    .IsRequired()
                    .HasColumnName("cargador")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContratoMarco)
                    .IsRequired()
                    .HasColumnName("contrato_marco")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cpu)
                    .IsRequired()
                    .HasColumnName("cpu")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeploymentState)
                    .IsRequired()
                    .HasColumnName("deployment_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirPropNow)
                    .HasColumnName("dir_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirPropietario)
                    .IsRequired()
                    .HasColumnName("dir_propietario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Disco)
                    .IsRequired()
                    .HasColumnName("disco")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Disquetera)
                    .IsRequired()
                    .HasColumnName("disquetera")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoAnexo)
                    .IsRequired()
                    .HasColumnName("estado_anexo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoEquipo)
                    .IsRequired()
                    .HasColumnName("estado_equipo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fabricante)
                    .IsRequired()
                    .HasColumnName("fabricante")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("fecha_compra")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDev)
                    .HasColumnName("fecha_dev")
                    .HasColumnType("date");

                entity.Property(e => e.FechaGarantia)
                    .HasColumnName("fecha_garantia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaMod)
                    .HasColumnName("fecha_mod")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnName("fecha_recepcion")
                    .HasColumnType("date");

                entity.Property(e => e.GarComercial)
                    .IsRequired()
                    .HasColumnName("gar_comercial")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GarSoporte)
                    .IsRequired()
                    .HasColumnName("gar_soporte")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GerPropNow)
                    .HasColumnName("ger_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GerPropietario)
                    .IsRequired()
                    .HasColumnName("ger_propietario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncidentState)
                    .IsRequired()
                    .HasColumnName("incident_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefPropNow)
                    .HasColumnName("jef_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefPropietario)
                    .IsRequired()
                    .HasColumnName("jef_propietario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LectExterno)
                    .IsRequired()
                    .HasColumnName("lect_externo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lectora)
                    .IsRequired()
                    .HasColumnName("lectora")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LectoraGrab)
                    .IsRequired()
                    .HasColumnName("lectora_grab")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Maletin)
                    .IsRequired()
                    .HasColumnName("maletin")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mouse)
                    .IsRequired()
                    .HasColumnName("mouse")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegPropNow)
                    .HasColumnName("neg_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegPropietario)
                    .IsRequired()
                    .HasColumnName("neg_propietario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("orden_compra")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Precio)
                    .IsRequired()
                    .HasColumnName("precio")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("proveedor")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ram)
                    .IsRequired()
                    .HasColumnName("ram")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SistemaOper)
                    .IsRequired()
                    .HasColumnName("sistema_oper")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Solpe)
                    .IsRequired()
                    .HasColumnName("solpe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teclado)
                    .IsRequired()
                    .HasColumnName("teclado")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoMon)
                    .IsRequired()
                    .HasColumnName("tipo_mon")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoPropiedad)
                    .IsRequired()
                    .HasColumnName("tipo_propiedad")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("ubicacion")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zonal)
                    .IsRequired()
                    .HasColumnName("zonal")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmdbCpuHist>(entity =>
            {
                entity.ToTable("cmdb_cpu_hist");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Anexo)
                    .IsRequired()
                    .HasColumnName("anexo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContratoMarco)
                    .IsRequired()
                    .HasColumnName("contrato_marco")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cpu)
                    .HasColumnName("cpu")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeploymentState)
                    .IsRequired()
                    .HasColumnName("deployment_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Disco)
                    .IsRequired()
                    .HasColumnName("disco")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Disquetera)
                    .IsRequired()
                    .HasColumnName("disquetera")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoAnexo)
                    .IsRequired()
                    .HasColumnName("estado_anexo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fabricante)
                    .IsRequired()
                    .HasColumnName("fabricante")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("fecha_compra")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDev)
                    .HasColumnName("fecha_dev")
                    .HasColumnType("date");

                entity.Property(e => e.FechaGarantia)
                    .HasColumnName("fecha_garantia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaMod)
                    .HasColumnName("fecha_mod")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRecepcion)
                    .HasColumnName("fecha_recepcion")
                    .HasColumnType("date");

                entity.Property(e => e.GarComercial)
                    .IsRequired()
                    .HasColumnName("gar_comercial")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GarSoporte)
                    .IsRequired()
                    .HasColumnName("gar_soporte")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncidentState)
                    .IsRequired()
                    .HasColumnName("incident_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lectora)
                    .IsRequired()
                    .HasColumnName("lectora")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LectoraGrab)
                    .IsRequired()
                    .HasColumnName("lectora_grab")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("orden_compra")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("proveedor")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ram)
                    .IsRequired()
                    .HasColumnName("ram")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SistemaOper)
                    .IsRequired()
                    .HasColumnName("sistema_oper")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Solpe)
                    .IsRequired()
                    .HasColumnName("solpe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoPropiedad)
                    .IsRequired()
                    .HasColumnName("tipo_propiedad")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnName("ubicacion")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zonal)
                    .IsRequired()
                    .HasColumnName("zonal")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmdbLicencia>(entity =>
            {
                entity.ToTable("cmdb_licencia");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodAct)
                    .HasColumnName("cod_act")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeploymentState)
                    .IsRequired()
                    .HasColumnName("deployment_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirProp)
                    .HasColumnName("dir_prop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipoLic)
                    .HasColumnName("equipo_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fabric)
                    .HasColumnName("fabric")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaComp)
                    .HasColumnName("fecha_comp")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFinMant)
                    .HasColumnName("fecha_fin_mant")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIniMant)
                    .HasColumnName("fecha_ini_mant")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRece)
                    .HasColumnName("fecha_rece")
                    .HasColumnType("date");

                entity.Property(e => e.GerProp)
                    .HasColumnName("ger_prop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Grupo)
                    .HasColumnName("grupo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncidentState)
                    .IsRequired()
                    .HasColumnName("incident_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefProp)
                    .HasColumnName("jef_prop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mante)
                    .HasColumnName("mante")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegProp)
                    .HasColumnName("neg_prop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordecompra)
                    .HasColumnName("ordecompra")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlatSo)
                    .HasColumnName("plat_so")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreUni)
                    .HasColumnName("pre_uni")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Proveedor)
                    .HasColumnName("proveedor")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SwGenerico)
                    .HasColumnName("sw_generico")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoLic)
                    .HasColumnName("tipo_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoMone)
                    .HasColumnName("tipo_mone")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoSw)
                    .HasColumnName("tipo_sw")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnName("valid")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmdbMonPer>(entity =>
            {
                entity.ToTable("cmdb_mon_per");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Anexo)
                    .IsRequired()
                    .HasColumnName("anexo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContMarco)
                    .IsRequired()
                    .HasColumnName("cont_marco")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DepState)
                    .IsRequired()
                    .HasColumnName("dep_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasColumnName("detalle")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirPro)
                    .IsRequired()
                    .HasColumnName("dir_pro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirPropNow)
                    .IsRequired()
                    .HasColumnName("dir_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstAnexo)
                    .IsRequired()
                    .HasColumnName("est_anexo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstComp)
                    .IsRequired()
                    .HasColumnName("est_comp")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fabric)
                    .IsRequired()
                    .HasColumnName("fabric")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaComp)
                    .HasColumnName("fecha_comp")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDev)
                    .HasColumnName("fecha_dev")
                    .HasColumnType("date");

                entity.Property(e => e.FechaGar)
                    .HasColumnName("fecha_gar")
                    .HasColumnType("date");

                entity.Property(e => e.FechaModH)
                    .HasColumnName("fecha_mod_h")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRep)
                    .HasColumnName("fecha_rep")
                    .HasColumnType("date");

                entity.Property(e => e.GarCom)
                    .IsRequired()
                    .HasColumnName("gar_com")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GarSop)
                    .IsRequired()
                    .HasColumnName("gar_sop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GerPro)
                    .IsRequired()
                    .HasColumnName("ger_pro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GerPropNow)
                    .IsRequired()
                    .HasColumnName("ger_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncState)
                    .IsRequired()
                    .HasColumnName("inc_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefPro)
                    .IsRequired()
                    .HasColumnName("jef_pro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefPropNow)
                    .IsRequired()
                    .HasColumnName("jef_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Local)
                    .IsRequired()
                    .HasColumnName("local")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegPro)
                    .IsRequired()
                    .HasColumnName("neg_pro")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegPropNow)
                    .IsRequired()
                    .HasColumnName("neg_prop_now")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnName("note")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenCo)
                    .IsRequired()
                    .HasColumnName("orden_co")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("owner")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Precio)
                    .IsRequired()
                    .HasColumnName("precio")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Proved)
                    .IsRequired()
                    .HasColumnName("proved")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Solpe)
                    .IsRequired()
                    .HasColumnName("solpe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoMon)
                    .IsRequired()
                    .HasColumnName("tipo_mon")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoProp)
                    .IsRequired()
                    .HasColumnName("tipo_prop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypePer)
                    .IsRequired()
                    .HasColumnName("type_per")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ubica)
                    .IsRequired()
                    .HasColumnName("ubica")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zonal)
                    .IsRequired()
                    .HasColumnName("zonal")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmdbMonPerHist>(entity =>
            {
                entity.ToTable("cmdb_mon_per_hist");

                entity.HasIndex(e => e.Id)
                    .HasName("id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Anexo)
                    .HasColumnName("anexo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContMarco)
                    .HasColumnName("cont_marco")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DepState)
                    .IsRequired()
                    .HasColumnName("dep_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstAnexo)
                    .HasColumnName("est_anexo")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fabric)
                    .HasColumnName("fabric")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaComp)
                    .HasColumnName("fecha_comp")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDev)
                    .HasColumnName("fecha_dev")
                    .HasColumnType("date");

                entity.Property(e => e.FechaGar)
                    .HasColumnName("fecha_gar")
                    .HasColumnType("date");

                entity.Property(e => e.FechaModH)
                    .HasColumnName("fecha_mod_h")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRep)
                    .HasColumnName("fecha_rep")
                    .HasColumnType("date");

                entity.Property(e => e.GarCom)
                    .HasColumnName("gar_com")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GarSop)
                    .HasColumnName("gar_sop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IncState)
                    .IsRequired()
                    .HasColumnName("inc_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Local)
                    .HasColumnName("local")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenCo)
                    .HasColumnName("orden_co")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Proved)
                    .HasColumnName("proved")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serie)
                    .HasColumnName("serie")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Solpe)
                    .HasColumnName("solpe")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ubica)
                    .HasColumnName("ubica")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zonal)
                    .HasColumnName("zonal")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CmdbMoviles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cmdb_moviles");

                entity.Property(e => e.BenefCenter)
                    .HasColumnName("benef_center")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ccr)
                    .HasColumnName("ccr")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CostCenter)
                    .HasColumnName("cost_center")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DateDeliver)
                    .HasColumnName("date_deliver")
                    .HasColumnType("date");

                entity.Property(e => e.DeployState)
                    .IsRequired()
                    .HasColumnName("deploy_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FechaEntrega).HasColumnName("fecha_entrega");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ImeiChip)
                    .HasColumnName("imei_chip")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InciState)
                    .IsRequired()
                    .HasColumnName("inci_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Line)
                    .HasColumnName("line")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Plan)
                    .HasColumnName("plan")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PlanDetail)
                    .HasColumnName("plan_detail")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rpm)
                    .HasColumnName("rpm")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ConditionAction>(entity =>
            {
                entity.ToTable("condition_action");

                entity.HasIndex(e => e.ActionNumber)
                    .HasName("condition_action_action_number");

                entity.HasIndex(e => e.ActionValue)
                    .HasName("condition_action_action_value");

                entity.HasIndex(e => e.AttributeId)
                    .HasName("condition_action_attribute_id");

                entity.HasIndex(e => e.ConditionId)
                    .HasName("condition_action_condition_id");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("condition_action_object_id");

                entity.HasIndex(e => e.OperatorId)
                    .HasName("condition_action_operator_id");

                entity.HasIndex(e => e.Selector)
                    .HasName("condition_action_selector");

                entity.HasIndex(e => new { e.ConditionId, e.ActionNumber })
                    .HasName("condition_action_number_unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.ConditionId, e.ObjectId, e.AttributeId, e.OperatorId, e.Selector, e.ActionValue })
                    .HasName("condition_action_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ActionNumber)
                    .HasColumnName("action_number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActionValue)
                    .HasColumnName("action_value")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attribute_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operator_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Selector)
                    .HasColumnName("selector")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ConditionAttribute>(entity =>
            {
                entity.ToTable("condition_attribute");

                entity.HasIndex(e => e.Name)
                    .HasName("condition_attribute_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ConditionExpression>(entity =>
            {
                entity.ToTable("condition_expression");

                entity.HasIndex(e => e.AttributeId)
                    .HasName("condition_expression_attribute_id");

                entity.HasIndex(e => e.CompareValue)
                    .HasName("condition_expression_compare_value");

                entity.HasIndex(e => e.ConditionId)
                    .HasName("condition_expression_condition_id");

                entity.HasIndex(e => e.ObjectId)
                    .HasName("condition_expression_object_id");

                entity.HasIndex(e => e.OperatorId)
                    .HasName("condition_expression_operator_id");

                entity.HasIndex(e => e.Selector)
                    .HasName("condition_expression_selector");

                entity.HasIndex(e => new { e.ConditionId, e.ObjectId, e.AttributeId, e.OperatorId, e.Selector, e.CompareValue })
                    .HasName("condition_expression_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("attribute_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CompareValue)
                    .HasColumnName("compare_value")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConditionId)
                    .HasColumnName("condition_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operator_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Selector)
                    .HasColumnName("selector")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ConditionObject>(entity =>
            {
                entity.ToTable("condition_object");

                entity.HasIndex(e => e.Name)
                    .HasName("condition_object_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ConditionOperator>(entity =>
            {
                entity.ToTable("condition_operator");

                entity.HasIndex(e => e.Name)
                    .HasName("condition_operator_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Configitem>(entity =>
            {
                entity.ToTable("configitem");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_configitem_change_by_id");

                entity.HasIndex(e => e.ClassId)
                    .HasName("configitem_class_id");

                entity.HasIndex(e => e.ConfigitemNumber)
                    .HasName("configitem_U_105")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_configitem_create_by_id");

                entity.HasIndex(e => e.CurDeplStateId)
                    .HasName("configitem_cur_depl_state_id");

                entity.HasIndex(e => e.CurInciStateId)
                    .HasName("configitem_cur_inci_state_id");

                entity.HasIndex(e => e.LastVersionId)
                    .HasName("configitem_last_version_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.ClassId)
                    .HasColumnName("class_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConfigitemNumber)
                    .IsRequired()
                    .HasColumnName("configitem_number")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CurDeplStateId)
                    .HasColumnName("cur_depl_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CurInciStateId)
                    .HasColumnName("cur_inci_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastVersionId)
                    .HasColumnName("last_version_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ConfigitemCounter>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PRIMARY");

                entity.ToTable("configitem_counter");

                entity.Property(e => e.ClassId)
                    .HasColumnName("class_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Counter)
                    .IsRequired()
                    .HasColumnName("counter")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CounterType)
                    .IsRequired()
                    .HasColumnName("counter_type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ConfigitemDefinition>(entity =>
            {
                entity.ToTable("configitem_definition");

                entity.HasIndex(e => e.ClassId)
                    .HasName("FK_configitem_definition_class_id_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_configitem_definition_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassId)
                    .HasColumnName("class_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConfigitemDefinition1)
                    .IsRequired()
                    .HasColumnName("configitem_definition");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ConfigitemHistory>(entity =>
            {
                entity.ToTable("configitem_history");

                entity.HasIndex(e => e.ConfigitemId)
                    .HasName("FK_configitem_history_configitem_id_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_configitem_history_create_by_id");

                entity.HasIndex(e => e.TypeId)
                    .HasName("FK_configitem_history_type_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ConfigitemId)
                    .HasColumnName("configitem_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ConfigitemHistoryType>(entity =>
            {
                entity.ToTable("configitem_history_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_configitem_history_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_configitem_history_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("configitem_history_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_configitem_history_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ConfigitemVersion>(entity =>
            {
                entity.ToTable("configitem_version");

                entity.HasIndex(e => e.ConfigitemId)
                    .HasName("configitem_version_configitem_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_configitem_version_create_by_id");

                entity.HasIndex(e => e.DefinitionId)
                    .HasName("FK_configitem_version_definition_id_id");

                entity.HasIndex(e => e.DeplStateId)
                    .HasName("configitem_version_depl_state_id");

                entity.HasIndex(e => e.InciStateId)
                    .HasName("configitem_version_inci_state_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ConfigitemId)
                    .HasColumnName("configitem_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.DefinitionId)
                    .HasColumnName("definition_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeplStateId)
                    .HasColumnName("depl_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InciStateId)
                    .HasColumnName("inci_state_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CustomerCompany>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("customer_company");

                entity.HasIndex(e => e.Name)
                    .HasName("customer_company_name")
                    .IsUnique();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CustomerPreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer_preferences");

                entity.HasIndex(e => e.UserId)
                    .HasName("customer_preferences_user_id");

                entity.Property(e => e.PreferencesKey)
                    .IsRequired()
                    .HasColumnName("preferences_key")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferencesValue)
                    .HasColumnName("preferences_value")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CustomerUser>(entity =>
            {
                entity.ToTable("customer_user");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_customer_user_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_customer_user_create_by_id");

                entity.HasIndex(e => e.Login)
                    .HasName("customer_user_login")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_customer_user_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ceco)
                    .HasColumnName("ceco")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CipJefeInmediato)
                    .HasColumnName("cip_jefe_inmediato")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Contrata)
                    .HasColumnName("contrata")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateFinLic)
                    .HasColumnName("date_fin_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateIniLic)
                    .HasColumnName("date_ini_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Directo)
                    .HasColumnName("directo")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Empresa2)
                    .HasColumnName("empresa2")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gerencia)
                    .HasColumnName("gerencia")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdTipoLic)
                    .HasColumnName("id_tipo_lic")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jefatura)
                    .HasColumnName("jefatura")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jefe)
                    .HasColumnName("jefe")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefeInmediato)
                    .HasColumnName("jefe_inmediato")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pw)
                    .HasColumnName("pw")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rpm)
                    .HasColumnName("rpm")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sigla)
                    .HasColumnName("sigla")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Supervision)
                    .HasColumnName("supervision")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CustomerUserInter>(entity =>
            {
                entity.ToTable("customer_user_inter");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_customer_user_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_customer_user_create_by_id");

                entity.HasIndex(e => e.Login)
                    .HasName("customer_user_login")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_customer_user_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ceco)
                    .IsRequired()
                    .HasColumnName("ceco")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CipJefeInmediato)
                    .HasColumnName("cip_jefe_inmediato")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateFinLic)
                    .IsRequired()
                    .HasColumnName("date_fin_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateIniLic)
                    .IsRequired()
                    .HasColumnName("date_ini_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Directo)
                    .HasColumnName("directo")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gerencia)
                    .HasColumnName("gerencia")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdTipoLic)
                    .HasColumnName("id_tipo_lic")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jefatura)
                    .HasColumnName("jefatura")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jefe)
                    .HasColumnName("jefe")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefeInmediato)
                    .HasColumnName("jefe_inmediato")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pw)
                    .HasColumnName("pw")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rpm)
                    .HasColumnName("rpm")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sigla)
                    .HasColumnName("sigla")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Supervision)
                    .HasColumnName("supervision")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CustomerUserRaw>(entity =>
            {
                entity.HasKey(e => e.Cip)
                    .HasName("PRIMARY");

                entity.ToTable("customer_user_raw");

                entity.Property(e => e.Cip)
                    .HasColumnName("CIP")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApeMaternoJefeInmediato)
                    .HasColumnName("APE_MATERNO_JEFE_INMEDIATO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApePaternoJefeInmediato)
                    .HasColumnName("APE_PATERNO_JEFE_INMEDIATO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnName("APELLIDO_MATERNO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnName("APELLIDO_PATERNO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ceco)
                    .HasColumnName("ceco")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Correo)
                    .HasColumnName("CORREO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateFinLic)
                    .HasColumnName("date_fin_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateIniLic)
                    .HasColumnName("date_ini_lic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirperTelefCel)
                    .HasColumnName("DIRPER_TELEF_CEL")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirperTelefDire)
                    .HasColumnName("DIRPER_TELEF_DIRE")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DirperTelefRpm)
                    .HasColumnName("DIRPER_TELEF_RPM")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaBaja)
                    .IsRequired()
                    .HasColumnName("FECHA_BAJA")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdJefeInmediato)
                    .HasColumnName("ID_JEFE_INMEDIATO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdTipoLic)
                    .HasColumnName("id_tipo_lic")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreDireccion)
                    .HasColumnName("NOMBRE_DIRECCION")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreEmpresa)
                    .HasColumnName("NOMBRE_EMPRESA")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreGerencia)
                    .HasColumnName("NOMBRE_GERENCIA")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreJefatura)
                    .HasColumnName("NOMBRE_JEFATURA")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombrePuesto)
                    .IsRequired()
                    .HasColumnName("NOMBRE_PUESTO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreResponsableJefatura)
                    .HasColumnName("NOMBRE_RESPONSABLE_JEFATURA")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreSup)
                    .HasColumnName("NOMBRE_SUP")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("NOMBRES")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombresJefeInmediato)
                    .HasColumnName("NOMBRES_JEFE_INMEDIATO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombresSede)
                    .HasColumnName("NOMBRES_SEDE")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasColumnName("NUMERO_DOCUMENTO")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sigla)
                    .HasColumnName("SIGLA")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CustomerUserTmp>(entity =>
            {
                entity.ToTable("customer_user_tmp");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_customer_user_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_customer_user_create_by_id");

                entity.HasIndex(e => e.Login)
                    .HasName("customer_user_login")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_customer_user_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CipJefeInmediato)
                    .HasColumnName("cip_jefe_inmediato")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Directo)
                    .HasColumnName("directo")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gerencia)
                    .HasColumnName("gerencia")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jefatura)
                    .HasColumnName("jefatura")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jefe)
                    .HasColumnName("jefe")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JefeInmediato)
                    .HasColumnName("jefe_inmediato")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pw)
                    .HasColumnName("pw")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rpm)
                    .HasColumnName("rpm")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DynamicField>(entity =>
            {
                entity.ToTable("dynamic_field");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_dynamic_field_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_dynamic_field_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("dynamic_field_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_dynamic_field_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config).HasColumnName("config");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.FieldOrder)
                    .HasColumnName("field_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FieldType)
                    .IsRequired()
                    .HasColumnName("field_type")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InternalField)
                    .HasColumnName("internal_field")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("object_type")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<DynamicFieldValue>(entity =>
            {
                entity.ToTable("dynamic_field_value");

                entity.HasIndex(e => new { e.FieldId, e.ValueDate })
                    .HasName("dynamic_field_value_search_date");

                entity.HasIndex(e => new { e.FieldId, e.ValueInt })
                    .HasName("dynamic_field_value_search_int");

                entity.HasIndex(e => new { e.ObjectId, e.FieldId })
                    .HasName("dynamic_field_value_field_values");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FieldId)
                    .HasColumnName("field_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ValueDate).HasColumnName("value_date");

                entity.Property(e => e.ValueInt)
                    .HasColumnName("value_int")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ValueText)
                    .HasColumnName("value_text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FaqAttachment>(entity =>
            {
                entity.ToTable("faq_attachment");

                entity.HasIndex(e => e.FaqId)
                    .HasName("faq_attachment_faq_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Changed).HasColumnName("changed");

                entity.Property(e => e.ChangedBy)
                    .HasColumnName("changed_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.ContentSize)
                    .HasColumnName("content_size")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FaqId)
                    .HasColumnName("faq_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Inlineattachment)
                    .HasColumnName("inlineattachment")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<FaqCategory>(entity =>
            {
                entity.ToTable("faq_category");

                entity.HasIndex(e => e.Name)
                    .HasName("faq_category_name");

                entity.HasIndex(e => e.ParentId)
                    .HasName("faq_category_parent_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("faq_category_valid_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Changed).HasColumnName("changed");

                entity.Property(e => e.ChangedBy)
                    .HasColumnName("changed_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<FaqCategoryGroup>(entity =>
            {
                entity.ToTable("faq_category_group");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("faq_category_group_category_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Changed).HasColumnName("changed");

                entity.Property(e => e.ChangedBy)
                    .HasColumnName("changed_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FaqHistory>(entity =>
            {
                entity.ToTable("faq_history");

                entity.HasIndex(e => e.ItemId)
                    .HasName("faq_history_item_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Changed).HasColumnName("changed");

                entity.Property(e => e.ChangedBy)
                    .HasColumnName("changed_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FaqItem>(entity =>
            {
                entity.ToTable("faq_item");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("faq_item_category_id");

                entity.HasIndex(e => e.StateId)
                    .HasName("faq_item_state_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("faq_item_valid_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Changed).HasColumnName("changed");

                entity.Property(e => e.ChangedBy)
                    .HasColumnName("changed_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FField1)
                    .HasColumnName("f_field1")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FField2)
                    .HasColumnName("f_field2")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FField3)
                    .HasColumnName("f_field3")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FField4)
                    .HasColumnName("f_field4")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FField5)
                    .HasColumnName("f_field5")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FField6)
                    .HasColumnName("f_field6")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FKeywords)
                    .HasColumnName("f_keywords")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FLanguageId)
                    .HasColumnName("f_language_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("f_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FNumber)
                    .IsRequired()
                    .HasColumnName("f_number")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FSubject)
                    .HasColumnName("f_subject")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<FaqLanguage>(entity =>
            {
                entity.ToTable("faq_language");

                entity.HasIndex(e => e.Name)
                    .HasName("faq_language_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FaqLog>(entity =>
            {
                entity.ToTable("faq_log");

                entity.HasIndex(e => e.ItemId)
                    .HasName("faq_log_item_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Interface)
                    .IsRequired()
                    .HasColumnName("interface")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserAgent)
                    .HasColumnName("user_agent")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FaqState>(entity =>
            {
                entity.ToTable("faq_state");

                entity.HasIndex(e => e.Name)
                    .HasName("faq_state_name")
                    .IsUnique();

                entity.HasIndex(e => e.TypeId)
                    .HasName("faq_state_type_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FaqStateType>(entity =>
            {
                entity.ToTable("faq_state_type");

                entity.HasIndex(e => e.Name)
                    .HasName("faq_state_type_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FaqVoting>(entity =>
            {
                entity.ToTable("faq_voting");

                entity.HasIndex(e => e.ItemId)
                    .HasName("faq_voting_item_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("created_by")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Interface)
                    .HasColumnName("interface")
                    .HasColumnType("varchar(80)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<FollowUpPossible>(entity =>
            {
                entity.ToTable("follow_up_possible");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_follow_up_possible_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_follow_up_possible_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("follow_up_possible_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_follow_up_possible_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<GeneralCatalog>(entity =>
            {
                entity.ToTable("general_catalog");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_general_catalog_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_general_catalog_create_by_id");

                entity.HasIndex(e => new { e.GeneralCatalogClass, e.Name })
                    .HasName("general_catalog_U_797")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.GeneralCatalogClass)
                    .IsRequired()
                    .HasColumnName("general_catalog_class")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<GeneralCatalogPreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("general_catalog_preferences");

                entity.HasIndex(e => e.GeneralCatalogId)
                    .HasName("general_catalog_preferences_general_catalog_id");

                entity.Property(e => e.GeneralCatalogId)
                    .HasColumnName("general_catalog_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrefKey)
                    .IsRequired()
                    .HasColumnName("pref_key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrefValue)
                    .HasColumnName("pref_value")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GenericAgentJobs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("generic_agent_jobs");

                entity.HasIndex(e => e.JobName)
                    .HasName("generic_agent_jobs_job_name");

                entity.Property(e => e.JobKey)
                    .IsRequired()
                    .HasColumnName("job_key")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("job_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JobValue)
                    .HasColumnName("job_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GiDebuggerEntry>(entity =>
            {
                entity.ToTable("gi_debugger_entry");

                entity.HasIndex(e => e.CommunicationId)
                    .HasName("gi_debugger_entry_communication_id")
                    .IsUnique();

                entity.HasIndex(e => e.CreateTime)
                    .HasName("gi_debugger_entry_create_time");

                entity.HasIndex(e => e.WebserviceId)
                    .HasName("FK_gi_debugger_entry_webservice_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CommunicationId)
                    .IsRequired()
                    .HasColumnName("communication_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommunicationType)
                    .IsRequired()
                    .HasColumnName("communication_type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.RemoteIp)
                    .HasColumnName("remote_ip")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebserviceId)
                    .HasColumnName("webservice_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GiDebuggerEntryContent>(entity =>
            {
                entity.ToTable("gi_debugger_entry_content");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("gi_debugger_entry_content_create_time");

                entity.HasIndex(e => e.DebugLevel)
                    .HasName("gi_debugger_entry_content_debug_level");

                entity.HasIndex(e => e.GiDebuggerEntryId)
                    .HasName("FK_gi_debugger_entry_content_gi_debugger_entry_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.DebugLevel)
                    .IsRequired()
                    .HasColumnName("debug_level")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GiDebuggerEntryId)
                    .HasColumnName("gi_debugger_entry_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GiObjectLockState>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gi_object_lock_state");

                entity.HasIndex(e => new { e.WebserviceId, e.ObjectType, e.ObjectId })
                    .HasName("gi_object_lock_state_list")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebserviceId, e.ObjectType, e.ObjectId, e.LockState })
                    .HasName("object_lock_state_list_state");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.LockState)
                    .IsRequired()
                    .HasColumnName("lock_state")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockStateCounter)
                    .HasColumnName("lock_state_counter")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasColumnName("object_type")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebserviceId)
                    .HasColumnName("webservice_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GiWebserviceConfig>(entity =>
            {
                entity.ToTable("gi_webservice_config");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_gi_webservice_config_change_by_id");

                entity.HasIndex(e => e.ConfigMd5)
                    .HasName("gi_webservice_config_config_md5")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_gi_webservice_config_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("gi_webservice_config_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_gi_webservice_config_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.ConfigMd5)
                    .IsRequired()
                    .HasColumnName("config_md5")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<GiWebserviceConfigHistory>(entity =>
            {
                entity.ToTable("gi_webservice_config_history");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_gi_webservice_config_history_change_by_id");

                entity.HasIndex(e => e.ConfigId)
                    .HasName("FK_gi_webservice_config_history_config_id_id");

                entity.HasIndex(e => e.ConfigMd5)
                    .HasName("gi_webservice_config_history_config_md5")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_gi_webservice_config_history_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.ConfigId)
                    .HasColumnName("config_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConfigMd5)
                    .IsRequired()
                    .HasColumnName("config_md5")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");
            });

            modelBuilder.Entity<GrepContrata>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("PRIMARY");

                entity.ToTable("grep_contrata");

                entity.Property(e => e.Dni)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CuentaRed)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Telefono)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioActualiza)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepCtaRedSolMoviles>(entity =>
            {
                entity.ToTable("grep_cta_red_sol_moviles");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CuentaRed)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioModificacion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistro)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepDGuia>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Item })
                    .HasName("PRIMARY");

                entity.ToTable("grep_d_guia");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Item)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Documento)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Inventario)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Peso).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Serie)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usract).HasColumnType("int(11)");

                entity.Property(e => e.Usrcre).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioActualiza)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GrepFichaSolMoviles>(entity =>
            {
                entity.HasKey(e => e.IdSolMov)
                    .HasName("PRIMARY");

                entity.ToTable("grep_ficha_sol_moviles");

                entity.Property(e => e.IdSolMov).HasColumnType("int(11)");

                entity.Property(e => e.CipColaborador)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CipMando)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CipSolicitante)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CodSolMov)
                    .HasColumnType("char(7)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DatoAdicional)
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DetallePlan)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DevuelveEquipoAnt)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocalidadEntrega)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ModalidadEntrega)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ModeloEquipoDev)
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MotivoSolicitud)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroCelular)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Plan)
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SimCard)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TipoEquipo)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistro)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepMGuia>(entity =>
            {
                entity.ToTable("grep_m_guia");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AprobMtc)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Autorizado)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConsignacionPrestamo).HasColumnType("int(11)");

                entity.Property(e => e.DemostracionAlquiler).HasColumnType("int(11)");

                entity.Property(e => e.Despachado)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Destino)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Devolucion).HasColumnType("int(11)");

                entity.Property(e => e.Direccion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DniUsuario)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoProceso)
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gerencia)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdSolicitud).HasColumnType("int(11)");

                entity.Property(e => e.Jefatura)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Marca)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreUsuario)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NroCertInsc)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NroGuia)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NroSerieGuia)
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nrolicencia)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Obs)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Origen)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Otros).HasColumnType("int(11)");

                entity.Property(e => e.Placa)
                    .HasColumnName("placa")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RazonSocial)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reparacion).HasColumnType("int(11)");

                entity.Property(e => e.Ruc)
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RucTrans)
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subgerencia)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TelefonoContacto)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ticket)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TrasladoEmisor).HasColumnType("int(11)");

                entity.Property(e => e.TrasladoEstablecimientos).HasColumnType("int(11)");

                entity.Property(e => e.Unidad)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usract).HasColumnType("int(11)");

                entity.Property(e => e.Usrcre).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioActualiza)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsuarioContacto)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VentaCompra).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GrepParametro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("grep_parametro");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdParametro)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PermiteAgregar)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PermiteEliminar)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PermiteModificar)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PermiteMostrar)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioModifica)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'Admin'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepParametrovalor>(entity =>
            {
                entity.HasKey(e => e.IdParametroValor)
                    .HasName("PRIMARY");

                entity.ToTable("grep_parametrovalor");

                entity.Property(e => e.IdParametroValor)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Abreviatura)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdParametro)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdParametroValorPadre)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioModifica)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'Admin'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepSolicitud>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud)
                    .HasName("PRIMARY");

                entity.ToTable("grep_solicitud");

                entity.Property(e => e.IdSolicitud).HasColumnType("int(11)");

                entity.Property(e => e.ArchivoAcuerdoConfidencialidad)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CipAutorizador)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CipSolicitante)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CipUsuario)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CodigoSolicitud)
                    .HasColumnType("char(7)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Comentario)
                    .HasColumnType("varchar(3000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Contacto)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Contrata)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CuentaRedUsuario)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DestinoDireccion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DestinoLocal)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DestinoPiso)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DireccionFisica)
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DniAutorizador)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DniContrata)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DniSolicitante)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DniUsuario)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EmailAutorizador)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EnvioCorreoExterno).HasColumnType("int(1)");

                entity.Property(e => e.EnvioCorreoSmart).HasColumnType("int(11)");

                entity.Property(e => e.EnvioCorreoWeb).HasColumnType("int(1)");

                entity.Property(e => e.Estado)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EstadoProceso)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FlagGuia)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FlagInstComponentes)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FlagInstSoftware)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FlagPreEquipos)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FlagTrasladoEquipo).HasColumnType("int(11)");

                entity.Property(e => e.FlagTrasladoInf)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdModoLicenciamiento)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipSol).HasColumnType("int(11)");

                entity.Property(e => e.IdTipo2Componente)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipo2Equipo)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoAccion)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoSolicitud)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InventarioAntiguo)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroGuia)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieGuia)
                    .HasColumnType("varchar(3)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OrigenDireccion)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OrigenLocal)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OrigenPiso)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PisoUsuario).HasColumnType("smallint(6)");

                entity.Property(e => e.Rpmcontacto)
                    .HasColumnName("RPMContacto")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rpmsolicitante)
                    .HasColumnName("RPMSolicitante")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rpmusuario)
                    .HasColumnName("RPMUsuario")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SerieEquipoDestino)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SerieEquipoOrigen)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TelefonoContacto)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ticket)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TipoAccion).HasColumnType("int(11)");

                entity.Property(e => e.Usract).HasColumnType("int(11)");

                entity.Property(e => e.Usrcre).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioActualiza)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioAntiguo)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioOrigen)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepSolicitudrecurso>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudRecurso)
                    .HasName("PRIMARY");

                entity.ToTable("grep_solicitudrecurso");

                entity.Property(e => e.IdSolicitudRecurso).HasColumnType("int(11)");

                entity.Property(e => e.Cpu)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CuentaRed)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Disco)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Dominio)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EstadoRecurso)
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FlagPropiedad).HasColumnType("int(11)");

                entity.Property(e => e.IdSolicitud).HasColumnType("int(11)");

                entity.Property(e => e.IdTipSol).HasColumnType("int(11)");

                entity.Property(e => e.IdTipoAccion)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoRecurso)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoSoftware)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoSolicitud)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Licencia)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocalDestino)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LocalOrigen)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MacAddress)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Marca)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Modelo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Mouse)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NombreEstacion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroInventPropio)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroInventarioRecurso)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieMonitor)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieRecurso)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieRecursoDestino)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieRecursoOrigen)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OrdenCompraOffice)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PersonaContacto)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PisoDestino)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PisoOrigen)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ram)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Teclado)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TelefonoContacto)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TipoAccion).HasColumnType("int(11)");

                entity.Property(e => e.TipoEqRenovacionTecno)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UbicacionDestino)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UbicacionEquipo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UbicacionOrigen)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Usract).HasColumnType("int(11)");

                entity.Property(e => e.Usrcre).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioActualiza)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Velocidadcpu)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VersionSoftware)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepSolicitudrequerimiento>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudRequerimiento)
                    .HasName("PRIMARY");

                entity.ToTable("grep_solicitudrequerimiento");

                entity.Property(e => e.IdSolicitudRequerimiento).HasColumnType("int(11)");

                entity.Property(e => e.CuentaRed)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DireccionDestino)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FechaActualiza)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FechaRegistra)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdSolicitud).HasColumnType("int(11)");

                entity.Property(e => e.IdTipoAccion)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoComponente)
                    .HasColumnName("idTipoComponente")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoRecurso)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoSoftware)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdTipoSolicitud)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InventarioDestino)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InventarioOrigen)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LicenciaSoftware)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Local)
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Mouse)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroInventarioMonitor)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroInventarioRecurso)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieAsociado)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieMonitor)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NroSerieRecurso)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rpmcontacto)
                    .HasColumnName("RPMContacto")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SerieEquipoDestino)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SerieEquipoOrigen)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Teclado)
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TipoRequerimiento)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ubicacion)
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UbicacionDestino)
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UbicacionOrigen)
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioModifica)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistra)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GrepTiporequerimiento>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.UsuarioModifica })
                    .HasName("PRIMARY");

                entity.ToTable("grep_tiporequerimiento");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuarioModifica).HasColumnType("int(11)");

                entity.Property(e => e.CodParam)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Descrip)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenRegistro).HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsuarioRegistra).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GrepTiporequerimientoSubtipos>(entity =>
            {
                entity.ToTable("grep_tiporequerimiento_subtipos");

                entity.HasIndex(e => e.Idtipreq)
                    .HasName("Idtipreq");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CodParam)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Idtipreq)
                    .HasColumnType("int(11)")
                    .HasComment("Id Tipo Requerimiento");

                entity.Property(e => e.Titulo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsuarioModifica).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioRegistra).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GrepTipreqCombina>(entity =>
            {
                entity.ToTable("grep_tipreq_combina");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tipreq)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UsuarioModifica).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioRegistra).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GrepUsuarioautorizador>(entity =>
            {
                entity.ToTable("grep_usuarioautorizador");

                entity.HasComment("Lista de usuarios que tienen permiso de enviar correo a HD. ");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Cip)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DireccionGerenciaJefatura)
                    .IsRequired()
                    .HasColumnName("Direccion_Gerencia_Jefatura")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Dni)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Gerencia)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Jefatura)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NombresApellidos)
                    .IsRequired()
                    .HasColumnName("Nombres_Apellidos")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Tipo).HasColumnType("int(11)");

                entity.Property(e => e.UsuarioModifica)
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UsuarioRegistro)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<GroupCustomerUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("group_customer_user");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_group_customer_user_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_group_customer_user_create_by_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_customer_user_group_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("group_customer_user_user_id");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasColumnName("permission_key")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PermissionValue)
                    .HasColumnName("permission_value")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<GroupRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("group_role");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_group_role_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_group_role_create_by_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_role_group_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("group_role_role_id");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasColumnName("permission_key")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PermissionValue)
                    .HasColumnName("permission_value")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<GroupUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("group_user");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_group_user_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_group_user_create_by_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_user_group_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("group_user_user_id");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasColumnName("permission_key")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PermissionValue)
                    .HasColumnName("permission_value")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.ToTable("groups");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_groups_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_groups_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("groups_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_groups_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ImexportFormat>(entity =>
            {
                entity.ToTable("imexport_format");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("imexport_format_template_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DataKey)
                    .IsRequired()
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasColumnName("data_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImexportMapping>(entity =>
            {
                entity.ToTable("imexport_mapping");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("imexport_mapping_template_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImexportMappingFormat>(entity =>
            {
                entity.ToTable("imexport_mapping_format");

                entity.HasIndex(e => e.MappingId)
                    .HasName("imexport_mapping_format_mapping_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DataKey)
                    .IsRequired()
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasColumnName("data_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MappingId)
                    .HasColumnName("mapping_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImexportMappingObject>(entity =>
            {
                entity.ToTable("imexport_mapping_object");

                entity.HasIndex(e => e.MappingId)
                    .HasName("imexport_mapping_object_mapping_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DataKey)
                    .IsRequired()
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasColumnName("data_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MappingId)
                    .HasColumnName("mapping_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImexportObject>(entity =>
            {
                entity.ToTable("imexport_object");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("imexport_object_template_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DataKey)
                    .IsRequired()
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasColumnName("data_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImexportSearch>(entity =>
            {
                entity.ToTable("imexport_search");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("imexport_search_template_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DataKey)
                    .IsRequired()
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasColumnName("data_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("template_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<ImexportTemplate>(entity =>
            {
                entity.ToTable("imexport_template");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_imexport_template_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_imexport_template_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.ImexportFormat)
                    .IsRequired()
                    .HasColumnName("imexport_format")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImexportObject)
                    .IsRequired()
                    .HasColumnName("imexport_object")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<LinkObject>(entity =>
            {
                entity.ToTable("link_object");

                entity.HasIndex(e => e.Name)
                    .HasName("link_object_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LinkRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("link_relation");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_link_relation_create_by_id");

                entity.HasIndex(e => e.StateId)
                    .HasName("FK_link_relation_state_id_id");

                entity.HasIndex(e => e.TargetObjectId)
                    .HasName("FK_link_relation_target_object_id_id");

                entity.HasIndex(e => e.TypeId)
                    .HasName("FK_link_relation_type_id_id");

                entity.HasIndex(e => new { e.SourceObjectId, e.SourceKey, e.TargetObjectId, e.TargetKey, e.TypeId })
                    .HasName("link_relation_view")
                    .IsUnique();

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.SourceKey)
                    .IsRequired()
                    .HasColumnName("source_key")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SourceObjectId)
                    .HasColumnName("source_object_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.TargetKey)
                    .IsRequired()
                    .HasColumnName("target_key")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TargetObjectId)
                    .HasColumnName("target_object_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<LinkState>(entity =>
            {
                entity.ToTable("link_state");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_link_state_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_link_state_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("link_state_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_link_state_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<LinkType>(entity =>
            {
                entity.ToTable("link_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_link_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_link_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("link_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_link_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<MailAccount>(entity =>
            {
                entity.ToTable("mail_account");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_mail_account_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_mail_account_create_by_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_mail_account_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasColumnName("account_type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasColumnName("host")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImapFolder)
                    .HasColumnName("imap_folder")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pw)
                    .IsRequired()
                    .HasColumnName("pw")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Trusted)
                    .HasColumnName("trusted")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<NotificationEvent>(entity =>
            {
                entity.ToTable("notification_event");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_notification_event_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_notification_event_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("notification_event_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_notification_event_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Charset)
                    .IsRequired()
                    .HasColumnName("charset")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<NotificationEventItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("notification_event_item");

                entity.HasIndex(e => e.EventKey)
                    .HasName("notification_event_item_event_key");

                entity.HasIndex(e => e.EventValue)
                    .HasName("notification_event_item_event_value");

                entity.HasIndex(e => e.NotificationId)
                    .HasName("notification_event_item_notification_id");

                entity.Property(e => e.EventKey)
                    .IsRequired()
                    .HasColumnName("event_key")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EventValue)
                    .IsRequired()
                    .HasColumnName("event_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notification_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("notifications");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_notifications_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_notifications_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.NotificationCharset)
                    .IsRequired()
                    .HasColumnName("notification_charset")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationLanguage)
                    .IsRequired()
                    .HasColumnName("notification_language")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationType)
                    .IsRequired()
                    .HasColumnName("notification_type")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<OtrsTk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OTRS_TK");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.ColaEquipo)
                    .IsRequired()
                    .HasColumnName("Cola Equipo")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ComentarioCola)
                    .HasColumnName("Comentario Cola")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Criticidad)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoTicket)
                    .IsRequired()
                    .HasColumnName("Estado Ticket")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PuestoDeTrabajo)
                    .IsRequired()
                    .HasColumnName("Puesto de Trabajo")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timeout)
                    .HasColumnName("timeout")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TituloTk)
                    .HasColumnName("Titulo tk")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PackageRepository>(entity =>
            {
                entity.ToTable("package_repository");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_package_repository_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_package_repository_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InstallStatus)
                    .IsRequired()
                    .HasColumnName("install_status")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasColumnName("vendor")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PersonalQueues>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("personal_queues");

                entity.HasIndex(e => e.QueueId)
                    .HasName("personal_queues_queue_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("personal_queues_user_id");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PersonalServices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("personal_services");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("personal_services_service_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("personal_services_user_id");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PmActivity>(entity =>
            {
                entity.ToTable("pm_activity");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_pm_activity_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_pm_activity_create_by_id");

                entity.HasIndex(e => e.EntityId)
                    .HasName("pm_activity_entity_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PmActivityDialog>(entity =>
            {
                entity.ToTable("pm_activity_dialog");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_pm_activity_dialog_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_pm_activity_dialog_create_by_id");

                entity.HasIndex(e => e.EntityId)
                    .HasName("pm_activity_dialog_entity_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PmEntitySync>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pm_entity_sync");

                entity.HasIndex(e => new { e.EntityType, e.EntityId })
                    .HasName("pm_entity_sync_list")
                    .IsUnique();

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasColumnName("entity_type")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SyncState)
                    .IsRequired()
                    .HasColumnName("sync_state")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PmProcess>(entity =>
            {
                entity.ToTable("pm_process");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_pm_process_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_pm_process_create_by_id");

                entity.HasIndex(e => e.EntityId)
                    .HasName("pm_process_entity_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Layout)
                    .IsRequired()
                    .HasColumnName("layout");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateEntityId)
                    .IsRequired()
                    .HasColumnName("state_entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PmTransition>(entity =>
            {
                entity.ToTable("pm_transition");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_pm_transition_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_pm_transition_create_by_id");

                entity.HasIndex(e => e.EntityId)
                    .HasName("pm_transition_entity_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PmTransitionAction>(entity =>
            {
                entity.ToTable("pm_transition_action");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_pm_transition_action_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_pm_transition_action_create_by_id");

                entity.HasIndex(e => e.EntityId)
                    .HasName("pm_transition_action_entity_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Config)
                    .IsRequired()
                    .HasColumnName("config");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.EntityId)
                    .IsRequired()
                    .HasColumnName("entity_id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PostmasterFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("postmaster_filter");

                entity.HasIndex(e => e.FName)
                    .HasName("postmaster_filter_f_name");

                entity.Property(e => e.FKey)
                    .IsRequired()
                    .HasColumnName("f_key")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FName)
                    .IsRequired()
                    .HasColumnName("f_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FNot)
                    .HasColumnName("f_not")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FStop)
                    .HasColumnName("f_stop")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FType)
                    .IsRequired()
                    .HasColumnName("f_type")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FValue)
                    .IsRequired()
                    .HasColumnName("f_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ProcessId>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("process_id");

                entity.Property(e => e.ProcessChange)
                    .HasColumnName("process_change")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessCreate)
                    .HasColumnName("process_create")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessHost)
                    .IsRequired()
                    .HasColumnName("process_host")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessId1)
                    .IsRequired()
                    .HasColumnName("process_id")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasColumnName("process_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Queue>(entity =>
            {
                entity.ToTable("queue");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_queue_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_queue_create_by_id");

                entity.HasIndex(e => e.FollowUpId)
                    .HasName("FK_queue_follow_up_id_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("queue_group_id");

                entity.HasIndex(e => e.Name)
                    .HasName("queue_name")
                    .IsUnique();

                entity.HasIndex(e => e.SalutationId)
                    .HasName("FK_queue_salutation_id_id");

                entity.HasIndex(e => e.SignatureId)
                    .HasName("FK_queue_signature_id_id");

                entity.HasIndex(e => e.SystemAddressId)
                    .HasName("FK_queue_system_address_id_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_queue_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalendarName)
                    .HasColumnName("calendar_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.DefaultSignKey)
                    .HasColumnName("default_sign_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstResponseNotify)
                    .HasColumnName("first_response_notify")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FirstResponseTime)
                    .HasColumnName("first_response_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FollowUpId)
                    .HasColumnName("follow_up_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FollowUpLock)
                    .HasColumnName("follow_up_lock")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SalutationId)
                    .HasColumnName("salutation_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.SignatureId)
                    .HasColumnName("signature_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.SolutionNotify)
                    .HasColumnName("solution_notify")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.SolutionTime)
                    .HasColumnName("solution_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SystemAddressId)
                    .HasColumnName("system_address_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UnlockTimeout)
                    .HasColumnName("unlock_timeout")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateNotify)
                    .HasColumnName("update_notify")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QueueAutoResponse>(entity =>
            {
                entity.ToTable("queue_auto_response");

                entity.HasIndex(e => e.AutoResponseId)
                    .HasName("FK_queue_auto_response_auto_response_id_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_queue_auto_response_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_queue_auto_response_create_by_id");

                entity.HasIndex(e => e.QueueId)
                    .HasName("FK_queue_auto_response_queue_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoResponseId)
                    .HasColumnName("auto_response_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<QueuePreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("queue_preferences");

                entity.HasIndex(e => e.QueueId)
                    .HasName("queue_preferences_queue_id");

                entity.Property(e => e.PreferencesKey)
                    .IsRequired()
                    .HasColumnName("preferences_key")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferencesValue)
                    .HasColumnName("preferences_value")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<QueueStandardTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("queue_standard_template");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_queue_standard_template_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_queue_standard_template_create_by_id");

                entity.HasIndex(e => e.QueueId)
                    .HasName("FK_queue_standard_template_queue_id_id");

                entity.HasIndex(e => e.StandardTemplateId)
                    .HasName("FK_queue_standard_template_standard_template_id_id");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StandardTemplateId)
                    .HasColumnName("standard_template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("role_user");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_role_user_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_role_user_create_by_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("role_user_role_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("role_user_user_id");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_roles_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_roles_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("roles_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_roles_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.ToTable("salutation");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_salutation_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_salutation_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("salutation_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_salutation_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<SchedulerTaskList>(entity =>
            {
                entity.ToTable("scheduler_task_list");

                entity.HasIndex(e => e.TaskDataMd5)
                    .HasName("scheduler_task_list_task_data_md5")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.DueTime).HasColumnName("due_time");

                entity.Property(e => e.TaskData)
                    .IsRequired()
                    .HasColumnName("task_data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaskDataMd5)
                    .IsRequired()
                    .HasColumnName("task_data_md5")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasColumnName("task_type")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SearchProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("search_profile");

                entity.HasIndex(e => e.Login)
                    .HasName("search_profile_login");

                entity.HasIndex(e => e.ProfileName)
                    .HasName("search_profile_profile_name");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProfileKey)
                    .IsRequired()
                    .HasColumnName("profile_key")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProfileName)
                    .IsRequired()
                    .HasColumnName("profile_name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProfileType)
                    .IsRequired()
                    .HasColumnName("profile_type")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProfileValue)
                    .HasColumnName("profile_value")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("service");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_service_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_service_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("service_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Criticality)
                    .HasColumnName("criticality")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<ServiceCustomerUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("service_customer_user");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_service_customer_user_create_by_id");

                entity.HasIndex(e => e.CustomerUserLogin)
                    .HasName("service_customer_user_customer_user_login");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("service_customer_user_service_id");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CustomerUserLogin)
                    .IsRequired()
                    .HasColumnName("customer_user_login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ServicePreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("service_preferences");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("service_preferences_service_id");

                entity.Property(e => e.PreferencesKey)
                    .IsRequired()
                    .HasColumnName("preferences_key")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferencesValue)
                    .HasColumnName("preferences_value")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ServiceSla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("service_sla");

                entity.HasIndex(e => e.SlaId)
                    .HasName("FK_service_sla_sla_id_id");

                entity.HasIndex(e => new { e.ServiceId, e.SlaId })
                    .HasName("service_sla_service_sla")
                    .IsUnique();

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SlaId)
                    .HasColumnName("sla_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.ToTable("sessions");

                entity.HasIndex(e => e.DataKey)
                    .HasName("sessions_data_key");

                entity.HasIndex(e => new { e.SessionId, e.DataKey })
                    .HasName("sessions_session_id_data_key");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DataKey)
                    .IsRequired()
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serialized)
                    .HasColumnName("serialized")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("session_id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.ToTable("signature");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_signature_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_signature_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("signature_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_signature_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Sla>(entity =>
            {
                entity.ToTable("sla");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_sla_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_sla_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("sla_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CalendarName)
                    .HasColumnName("calendar_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.FirstResponseNotify)
                    .HasColumnName("first_response_notify")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.FirstResponseTime)
                    .HasColumnName("first_response_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinTimeBetIncidents)
                    .HasColumnName("min_time_bet_incidents")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SolutionNotify)
                    .HasColumnName("solution_notify")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.SolutionTime)
                    .HasColumnName("solution_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateNotify)
                    .HasColumnName("update_notify")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<SlaPreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sla_preferences");

                entity.HasIndex(e => e.SlaId)
                    .HasName("sla_preferences_sla_id");

                entity.Property(e => e.PreferencesKey)
                    .IsRequired()
                    .HasColumnName("preferences_key")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferencesValue)
                    .HasColumnName("preferences_value")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SlaId)
                    .HasColumnName("sla_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<SmFeriados>(entity =>
            {
                entity.HasKey(e => e.IdFer)
                    .HasName("PRIMARY");

                entity.ToTable("sm_feriados");

                entity.Property(e => e.IdFer)
                    .HasColumnName("id_fer")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FerFecha)
                    .HasColumnName("fer_fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasColumnType("char(150)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<SmHorario>(entity =>
            {
                entity.HasKey(e => e.IdHor)
                    .HasName("PRIMARY");

                entity.ToTable("sm_horario");

                entity.Property(e => e.IdHor)
                    .HasColumnName("id_hor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HorFin).HasColumnName("hor_fin");

                entity.Property(e => e.HorInicio).HasColumnName("hor_inicio");
            });

            modelBuilder.Entity<SmOperaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sm_operaciones");

                entity.Property(e => e.CliExt)
                    .HasColumnName("cli_ext")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Codmes)
                    .HasColumnName("codmes")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiaSemana)
                    .HasColumnName("dia_semana")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Factor)
                    .HasColumnName("factor")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.FinAtencion).HasColumnName("fin_atencion");

                entity.Property(e => e.FlgNohorario)
                    .HasColumnName("flg_nohorario")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FlgNolaborable)
                    .HasColumnName("flg_nolaborable")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Horas)
                    .HasColumnName("horas")
                    .HasColumnType("varchar(41)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("char(3)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InicioAtencion).HasColumnName("inicio_atencion");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minutos)
                    .HasColumnName("minutos")
                    .HasColumnType("bigint(21)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(201)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoSoporte)
                    .HasColumnName("tipo_soporte")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tn)
                    .IsRequired()
                    .HasColumnName("tn")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Torre)
                    .HasColumnName("torre")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(23,1)");
            });

            modelBuilder.Entity<SmPreoperaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sm_preoperaciones");

                entity.Property(e => e.CliExt)
                    .HasColumnName("cli_ext")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Codmes)
                    .HasColumnName("codmes")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiaSemana)
                    .HasColumnName("dia_semana")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FinAtencion).HasColumnName("fin_atencion");

                entity.Property(e => e.FlgNohorario)
                    .HasColumnName("flg_nohorario")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FlgNolaborable)
                    .HasColumnName("flg_nolaborable")
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Horas)
                    .HasColumnName("horas")
                    .HasColumnType("varchar(41)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InicioAtencion).HasColumnName("inicio_atencion");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Minutos)
                    .HasColumnName("minutos")
                    .HasColumnType("bigint(21)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(201)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoSoporte)
                    .HasColumnName("tipo_soporte")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tn)
                    .IsRequired()
                    .HasColumnName("tn")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Torre)
                    .HasColumnName("torre")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SmServicios>(entity =>
            {
                entity.ToTable("sm_servicios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("char(3)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnName("cliente")
                    .HasColumnType("char(150)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Horasa)
                    .HasColumnName("horasa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Horasm)
                    .HasColumnName("horasm")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCliser)
                    .IsRequired()
                    .HasColumnName("id_cliser")
                    .HasColumnType("char(150)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ocompra)
                    .HasColumnName("ocompra")
                    .HasColumnType("char(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PreExtra)
                    .HasColumnName("pre_extra")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.PreOfic)
                    .HasColumnName("pre_ofic")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.RemoExtra)
                    .HasColumnName("remo_extra")
                    .HasColumnType("decimal(3,1)");

                entity.Property(e => e.RemoOfic)
                    .HasColumnName("remo_ofic")
                    .HasColumnType("decimal(3,1)");
            });

            modelBuilder.Entity<SmTorre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sm_torre");

                entity.Property(e => e.IdQuee)
                    .HasColumnName("id_quee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Torre)
                    .HasColumnName("torre")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SmimeSignerCertRelations>(entity =>
            {
                entity.ToTable("smime_signer_cert_relations");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_smime_signer_cert_relations_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_smime_signer_cert_relations_create_by_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CaFingerprint)
                    .IsRequired()
                    .HasColumnName("ca_fingerprint")
                    .HasColumnType("varchar(59)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CaHash)
                    .IsRequired()
                    .HasColumnName("ca_hash")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertFingerprint)
                    .IsRequired()
                    .HasColumnName("cert_fingerprint")
                    .HasColumnType("varchar(59)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CertHash)
                    .IsRequired()
                    .HasColumnName("cert_hash")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");
            });

            modelBuilder.Entity<StandardAttachment>(entity =>
            {
                entity.ToTable("standard_attachment");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_standard_attachment_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_standard_attachment_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("standard_attachment_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_standard_attachment_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<StandardTemplate>(entity =>
            {
                entity.ToTable("standard_template");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_standard_template_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_standard_template_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("standard_template_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_standard_template_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateType)
                    .IsRequired()
                    .HasColumnName("template_type")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'Answer'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<StandardTemplateAttachment>(entity =>
            {
                entity.ToTable("standard_template_attachment");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_standard_template_attachment_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_standard_template_attachment_create_by_id");

                entity.HasIndex(e => e.StandardAttachmentId)
                    .HasName("FK_standard_template_attachment_standard_attachment_id_id");

                entity.HasIndex(e => e.StandardTemplateId)
                    .HasName("FK_standard_template_attachment_standard_template_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.StandardAttachmentId)
                    .HasColumnName("standard_attachment_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StandardTemplateId)
                    .HasColumnName("standard_template_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("survey");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Introduction)
                    .HasColumnName("introduction")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationBody)
                    .HasColumnName("notification_body")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationSender)
                    .HasColumnName("notification_sender")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotificationSubject)
                    .HasColumnName("notification_subject")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendConditions)
                    .HasColumnName("send_conditions")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Surveynumber)
                    .HasColumnName("surveynumber")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SurveyAnswer>(entity =>
            {
                entity.ToTable("survey_answer");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("survey_answer_question_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("answer")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("question_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<SurveyQuestion>(entity =>
            {
                entity.ToTable("survey_question");

                entity.HasIndex(e => e.SurveyId)
                    .HasName("survey_question_survey_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AnswerRequired)
                    .HasColumnName("answer_required")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QuestionType)
                    .IsRequired()
                    .HasColumnName("question_type")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SurveyId)
                    .HasColumnName("survey_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<SurveyQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("survey_queue");

                entity.HasIndex(e => e.QueueId)
                    .HasName("survey_queue_queue_id");

                entity.HasIndex(e => e.SurveyId)
                    .HasName("survey_queue_survey_id");

                entity.HasIndex(e => new { e.SurveyId, e.QueueId })
                    .HasName("survey_queue_view")
                    .IsUnique();

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SurveyId)
                    .HasColumnName("survey_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<SurveyRequest>(entity =>
            {
                entity.ToTable("survey_request");

                entity.HasIndex(e => e.SurveyId)
                    .HasName("survey_request_survey_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("survey_request_ticket_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("survey_request_valid_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.PublicSurveyKey)
                    .IsRequired()
                    .HasColumnName("public_survey_key")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SendTime).HasColumnName("send_time");

                entity.Property(e => e.SendTo)
                    .IsRequired()
                    .HasColumnName("send_to")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SurveyId)
                    .HasColumnName("survey_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.VoteTime).HasColumnName("vote_time");
            });

            modelBuilder.Entity<SurveyVote>(entity =>
            {
                entity.ToTable("survey_vote");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("survey_vote_question_id");

                entity.HasIndex(e => e.RequestId)
                    .HasName("survey_vote_request_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.QuestionId)
                    .HasColumnName("question_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.VoteValue)
                    .IsRequired()
                    .HasColumnName("vote_value")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SystemAddress>(entity =>
            {
                entity.ToTable("system_address");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_system_address_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_system_address_create_by_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_system_address_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Value0)
                    .IsRequired()
                    .HasColumnName("value0")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value1)
                    .IsRequired()
                    .HasColumnName("value1")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value2)
                    .HasColumnName("value2")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value3)
                    .HasColumnName("value3")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SystemData>(entity =>
            {
                entity.HasKey(e => e.DataKey)
                    .HasName("PRIMARY");

                entity.ToTable("system_data");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_system_data_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_system_data_create_by_id");

                entity.Property(e => e.DataKey)
                    .HasColumnName("data_key")
                    .HasColumnType("varchar(160)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.DataValue).HasColumnName("data_value");
            });

            modelBuilder.Entity<SystemMaintenance>(entity =>
            {
                entity.ToTable("system_maintenance");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_system_maintenance_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_system_maintenance_create_by_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_system_maintenance_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.LoginMessage)
                    .HasColumnName("login_message")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotifyMessage)
                    .HasColumnName("notify_message")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowLoginMessage)
                    .HasColumnName("show_login_message")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StopDate)
                    .HasColumnName("stop_date")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TiReportAtenciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TI_Report_Atenciones");

                entity.Property(e => e.Cantidad).HasColumnType("bigint(21)");

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(201)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TiReportFlujoHistorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TI_Report_Flujo_Historial");

                entity.Property(e => e.Titulo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tn)
                    .IsRequired()
                    .HasColumnName("tn")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValueText)
                    .HasColumnName("value_text")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("ticket");

                entity.HasIndex(e => e.ArchiveFlag)
                    .HasName("ticket_archive_flag");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_create_by_id");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("ticket_create_time");

                entity.HasIndex(e => e.CreateTimeUnix)
                    .HasName("ticket_create_time_unix");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("ticket_customer_id");

                entity.HasIndex(e => e.CustomerUserId)
                    .HasName("ticket_customer_user_id");

                entity.HasIndex(e => e.EscalationResponseTime)
                    .HasName("ticket_escalation_response_time");

                entity.HasIndex(e => e.EscalationSolutionTime)
                    .HasName("ticket_escalation_solution_time");

                entity.HasIndex(e => e.EscalationTime)
                    .HasName("ticket_escalation_time");

                entity.HasIndex(e => e.EscalationUpdateTime)
                    .HasName("ticket_escalation_update_time");

                entity.HasIndex(e => e.QueueId)
                    .HasName("ticket_queue_id");

                entity.HasIndex(e => e.ResponsibleUserId)
                    .HasName("ticket_responsible_user_id");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("FK_ticket_service_id_id");

                entity.HasIndex(e => e.SlaId)
                    .HasName("FK_ticket_sla_id_id");

                entity.HasIndex(e => e.TicketLockId)
                    .HasName("ticket_ticket_lock_id");

                entity.HasIndex(e => e.TicketPriorityId)
                    .HasName("ticket_ticket_priority_id");

                entity.HasIndex(e => e.TicketStateId)
                    .HasName("ticket_ticket_state_id");

                entity.HasIndex(e => e.Timeout)
                    .HasName("ticket_timeout");

                entity.HasIndex(e => e.Title)
                    .HasName("ticket_title");

                entity.HasIndex(e => e.Tn)
                    .HasName("ticket_tn")
                    .IsUnique();

                entity.HasIndex(e => e.TypeId)
                    .HasName("ticket_type_id");

                entity.HasIndex(e => e.UntilTime)
                    .HasName("ticket_until_time");

                entity.HasIndex(e => e.UserId)
                    .HasName("ticket_user_id");

                entity.HasIndex(e => new { e.TicketStateId, e.TicketLockId })
                    .HasName("ticket_queue_view");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArchiveFlag)
                    .HasColumnName("archive_flag")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.CreateTimeUnix)
                    .HasColumnName("create_time_unix")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomerUserId)
                    .HasColumnName("customer_user_id")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EscalationResponseTime)
                    .HasColumnName("escalation_response_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscalationSolutionTime)
                    .HasColumnName("escalation_solution_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscalationTime)
                    .HasColumnName("escalation_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscalationUpdateTime)
                    .HasColumnName("escalation_update_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponsibleUserId)
                    .HasColumnName("responsible_user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SlaId)
                    .HasColumnName("sla_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketLockId)
                    .HasColumnName("ticket_lock_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.TicketPriorityId)
                    .HasColumnName("ticket_priority_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.TicketStateId)
                    .HasColumnName("ticket_state_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Timeout)
                    .HasColumnName("timeout")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tn)
                    .IsRequired()
                    .HasColumnName("tn")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.UntilTime)
                    .HasColumnName("until_time")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TicketFlag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ticket_flag");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_flag_create_by_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_flag_ticket_id");

                entity.HasIndex(e => new { e.TicketId, e.CreateBy })
                    .HasName("ticket_flag_ticket_id_create_by");

                entity.HasIndex(e => new { e.TicketId, e.TicketKey })
                    .HasName("ticket_flag_ticket_id_ticket_key");

                entity.HasIndex(e => new { e.TicketId, e.TicketKey, e.CreateBy })
                    .HasName("ticket_flag_per_user")
                    .IsUnique();

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TicketKey)
                    .IsRequired()
                    .HasColumnName("ticket_key")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TicketValue)
                    .HasColumnName("ticket_value")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TicketHistory>(entity =>
            {
                entity.ToTable("ticket_history");

                entity.HasIndex(e => e.ArticleId)
                    .HasName("FK_ticket_history_article_id_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_history_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_history_create_by_id");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("ticket_history_create_time");

                entity.HasIndex(e => e.HistoryTypeId)
                    .HasName("ticket_history_history_type_id");

                entity.HasIndex(e => e.OwnerId)
                    .HasName("ticket_history_owner_id");

                entity.HasIndex(e => e.PriorityId)
                    .HasName("ticket_history_priority_id");

                entity.HasIndex(e => e.QueueId)
                    .HasName("ticket_history_queue_id");

                entity.HasIndex(e => e.StateId)
                    .HasName("ticket_history_state_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_history_ticket_id");

                entity.HasIndex(e => e.TypeId)
                    .HasName("ticket_history_type_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.HistoryTypeId)
                    .HasColumnName("history_type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerId)
                    .HasColumnName("owner_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PriorityId)
                    .HasColumnName("priority_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StateId)
                    .HasColumnName("state_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TicketHistoryType>(entity =>
            {
                entity.ToTable("ticket_history_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_history_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_history_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("ticket_history_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_ticket_history_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TicketIndex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ticket_index");

                entity.HasIndex(e => e.GroupId)
                    .HasName("ticket_index_group_id");

                entity.HasIndex(e => e.QueueId)
                    .HasName("ticket_index_queue_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_index_ticket_id");

                entity.Property(e => e.CreateTimeUnix)
                    .HasColumnName("create_time_unix")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasColumnName("queue")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QueueId)
                    .HasColumnName("queue_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SLock)
                    .IsRequired()
                    .HasColumnName("s_lock")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SState)
                    .IsRequired()
                    .HasColumnName("s_state")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<TicketLockIndex>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ticket_lock_index");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_lock_index_ticket_id");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<TicketLockType>(entity =>
            {
                entity.ToTable("ticket_lock_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_lock_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_lock_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("ticket_lock_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_ticket_lock_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TicketLoopProtection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ticket_loop_protection");

                entity.HasIndex(e => e.SentDate)
                    .HasName("ticket_loop_protection_sent_date");

                entity.HasIndex(e => e.SentTo)
                    .HasName("ticket_loop_protection_sent_to");

                entity.Property(e => e.SentDate)
                    .IsRequired()
                    .HasColumnName("sent_date")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SentTo)
                    .IsRequired()
                    .HasColumnName("sent_to")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TicketPriority>(entity =>
            {
                entity.ToTable("ticket_priority");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_priority_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_priority_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("ticket_priority_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TicketState>(entity =>
            {
                entity.ToTable("ticket_state");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_state_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_state_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("ticket_state_name")
                    .IsUnique();

                entity.HasIndex(e => e.TypeId)
                    .HasName("FK_ticket_state_type_id_id");

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_ticket_state_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TicketStateType>(entity =>
            {
                entity.ToTable("ticket_state_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_state_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_state_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("ticket_state_type_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TicketType>(entity =>
            {
                entity.ToTable("ticket_type");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_type_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_type_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("ticket_type_name")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_ticket_type_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TicketWatcher>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ticket_watcher");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_ticket_watcher_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_ticket_watcher_create_by_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("ticket_watcher_ticket_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("ticket_watcher_user_id");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TimeAccounting>(entity =>
            {
                entity.ToTable("time_accounting");

                entity.HasIndex(e => e.ArticleId)
                    .HasName("FK_time_accounting_article_id_id");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_time_accounting_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_time_accounting_create_by_id");

                entity.HasIndex(e => e.TicketId)
                    .HasName("time_accounting_ticket_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.TimeUnit)
                    .HasColumnName("time_unit")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<TimeAccountingAction>(entity =>
            {
                entity.ToTable("time_accounting_action");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TimeAccountingProject>(entity =>
            {
                entity.ToTable("time_accounting_project");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Project)
                    .HasColumnName("project")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TimeAccountingTable>(entity =>
            {
                entity.ToTable("time_accounting_table");

                entity.HasIndex(e => e.UserId)
                    .HasName("time_accounting_table_user_id");

                entity.HasIndex(e => new { e.UserId, e.TimeStart })
                    .HasName("time_accounting_table_user_id_time_start");

                entity.HasIndex(e => new { e.ProjectId, e.ActionId, e.Period, e.TimeStart, e.TimeEnd })
                    .HasName("time_accounting_table_project_action_period_time_start_end");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("decimal(10,3)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("project_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeEnd).HasColumnName("time_end");

                entity.Property(e => e.TimeStart).HasColumnName("time_start");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TimeAccountingUser>(entity =>
            {
                entity.ToTable("time_accounting_user");

                entity.HasIndex(e => e.UserId)
                    .HasName("time_accounting_user_user_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Calendar)
                    .HasColumnName("calendar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateProject)
                    .HasColumnName("create_project")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShowOvertime)
                    .HasColumnName("show_overtime")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TimeAccountingUserPeriod>(entity =>
            {
                entity.ToTable("time_accounting_user_period");

                entity.HasIndex(e => new { e.Status, e.DateStart, e.DateEnd })
                    .HasName("time_accounting_user_period_user_status_date_start_end");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.DateEnd).HasColumnName("date_end");

                entity.Property(e => e.DateStart).HasColumnName("date_start");

                entity.Property(e => e.LeaveDays)
                    .HasColumnName("leave_days")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Overtime)
                    .HasColumnName("overtime")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PreferencePeriod)
                    .HasColumnName("preference_period")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WeeklyHours)
                    .HasColumnName("weekly_hours")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<UserPreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_preferences");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_preferences_user_id");

                entity.Property(e => e.PreferencesKey)
                    .IsRequired()
                    .HasColumnName("preferences_key")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferencesValue).HasColumnName("preferences_value");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_users_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_users_create_by_id");

                entity.HasIndex(e => e.Login)
                    .HasName("users_login")
                    .IsUnique();

                entity.HasIndex(e => e.ValidId)
                    .HasName("FK_users_valid_id_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pw)
                    .IsRequired()
                    .HasColumnName("pw")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidId)
                    .HasColumnName("valid_id")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Valid>(entity =>
            {
                entity.ToTable("valid");

                entity.HasIndex(e => e.ChangeBy)
                    .HasName("FK_valid_change_by_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("FK_valid_create_by_id");

                entity.HasIndex(e => e.Name)
                    .HasName("valid_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.ChangeBy)
                    .HasColumnName("change_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<VirtualFs>(entity =>
            {
                entity.ToTable("virtual_fs");

                entity.HasIndex(e => e.Backend)
                    .HasName("virtual_fs_backend");

                entity.HasIndex(e => e.Filename)
                    .HasName("virtual_fs_filename");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Backend)
                    .IsRequired()
                    .HasColumnName("backend")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BackendKey)
                    .IsRequired()
                    .HasColumnName("backend_key")
                    .HasColumnType("varchar(160)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<VirtualFsDb>(entity =>
            {
                entity.ToTable("virtual_fs_db");

                entity.HasIndex(e => e.Filename)
                    .HasName("virtual_fs_db_filename");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<VirtualFsPreferences>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("virtual_fs_preferences");

                entity.HasIndex(e => e.VirtualFsId)
                    .HasName("virtual_fs_preferences_virtual_fs_id");

                entity.HasIndex(e => new { e.PreferencesKey, e.PreferencesValue })
                    .HasName("virtual_fs_preferences_key_value");

                entity.Property(e => e.PreferencesKey)
                    .IsRequired()
                    .HasColumnName("preferences_key")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PreferencesValue)
                    .HasColumnName("preferences_value")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtualFsId)
                    .HasColumnName("virtual_fs_id")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<VwOtrsToLs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_OTRS_TO_LS");

                entity.Property(e => e.Anexo)
                    .IsRequired()
                    .HasColumnName("anexo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeploymentState)
                    .IsRequired()
                    .HasColumnName("deployment_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Empresa)
                    .HasColumnName("empresa")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaDev)
                    .HasColumnName("fecha_dev")
                    .HasColumnType("date");

                entity.Property(e => e.FechaMod)
                    .HasColumnName("fecha_mod")
                    .HasColumnType("date");

                entity.Property(e => e.Gerencia)
                    .HasColumnName("gerencia")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jefatura)
                    .HasColumnName("jefatura")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegPropietario)
                    .IsRequired()
                    .HasColumnName("neg_propietario")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrdenCompra)
                    .IsRequired()
                    .HasColumnName("orden_compra")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Precio)
                    .IsRequired()
                    .HasColumnName("precio")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoPropiedad)
                    .IsRequired()
                    .HasColumnName("tipo_propiedad")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WebUploadCache>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("web_upload_cache");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.ContentId)
                    .HasColumnName("content_id")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentSize)
                    .HasColumnName("content_size")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnName("content_type")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateTimeUnix)
                    .HasColumnName("create_time_unix")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Disposition)
                    .HasColumnName("disposition")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FormId)
                    .HasColumnName("form_id")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpLicencias>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WP_Licencias");

                entity.Property(e => e.CantidadLibre).HasColumnName("Cantidad_Libre");

                entity.Property(e => e.CantidadTotal).HasColumnName("Cantidad_Total");

                entity.Property(e => e.CantidadUso)
                    .HasColumnName("Cantidad_Uso")
                    .HasColumnType("bigint(21)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeploymentState)
                    .IsRequired()
                    .HasColumnName("deployment_state")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NegProp)
                    .HasColumnName("neg_prop")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SwGenerico)
                    .HasColumnName("sw_generico")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoSw)
                    .HasColumnName("tipo_sw")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<WpReportOtrs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WP_Report_OTRS");

                entity.Property(e => e.Anexo)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cip)
                    .IsRequired()
                    .HasColumnName("CIP")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoDeDespliegue)
                    .IsRequired()
                    .HasColumnName("Estado de Despliegue")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EstadoDelUsuario)
                    .HasColumnName("Estado del Usuario")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FechaDeDevolución)
                    .HasColumnName("Fecha de Devolución")
                    .HasColumnType("date");

                entity.Property(e => e.Gerencia)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Inventario)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Jefatura)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Negocio)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasColumnName("Nombre Completo")
                    .HasColumnType("varchar(201)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubGerencia)
                    .HasColumnName("Sub Gerencia")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoDePropiedad)
                    .IsRequired()
                    .HasColumnName("Tipo de Propiedad")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<XmlStorage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xml_storage");

                entity.HasIndex(e => e.XmlContentKey)
                    .HasName("xml_storage_xml_content_key");

                entity.HasIndex(e => new { e.XmlKey, e.XmlType })
                    .HasName("xml_storage_key_type");

                entity.Property(e => e.XmlContentKey)
                    .IsRequired()
                    .HasColumnName("xml_content_key")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XmlContentValue)
                    .HasColumnName("xml_content_value")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XmlKey)
                    .IsRequired()
                    .HasColumnName("xml_key")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XmlType)
                    .IsRequired()
                    .HasColumnName("xml_type")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
