using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class ArticleEntityTypeConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("article");

            builder.HasIndex(e => e.AMessageIdMd5)
                .HasName("article_message_id_md5");

            builder.HasIndex(e => e.ArticleSenderTypeId)
                .HasName("article_article_sender_type_id");

            builder.HasIndex(e => e.ArticleTypeId)
                .HasName("article_article_type_id");

            builder.HasIndex(e => e.ChangeBy)
                .HasName("FK_article_change_by_id");

            builder.HasIndex(e => e.CreateBy)
                .HasName("FK_article_create_by_id");

            builder.HasIndex(e => e.TicketId)
                .HasName("article_ticket_id");

            builder.HasIndex(e => e.ValidId)
                .HasName("FK_article_valid_id_id");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("bigint(20)");

            builder.Property(e => e.ABody)
                .IsRequired()
                .HasColumnName("a_body")
                .HasColumnType("mediumtext")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ACc)
                .HasColumnName("a_cc")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AContentType)
                .HasColumnName("a_content_type")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AFrom)
                .HasColumnName("a_from")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AInReplyTo)
                .HasColumnName("a_in_reply_to")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AMessageId)
                .HasColumnName("a_message_id")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AMessageIdMd5)
                .HasColumnName("a_message_id_md5")
                .HasColumnType("varchar(32)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AReferences)
                .HasColumnName("a_references")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.AReplyTo)
                .HasColumnName("a_reply_to")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ASubject)
                .HasColumnName("a_subject")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ATo)
                .HasColumnName("a_to")
                .HasColumnType("text")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.ArticleSenderTypeId)
                .HasColumnName("article_sender_type_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.ArticleTypeId)
                .HasColumnName("article_type_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.ChangeBy)
                .HasColumnName("change_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChangeTime).HasColumnName("change_time");

            builder.Property(e => e.ContentPath)
                .HasColumnName("content_path")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.CreateTime).HasColumnName("create_time");

            builder.Property(e => e.IncomingTime)
                .HasColumnName("incoming_time")
                .HasColumnType("int(11)");

            builder.Property(e => e.TicketId)
                .HasColumnName("ticket_id")
                .HasColumnType("bigint(20)");

            builder.Property(e => e.ValidId)
                .HasColumnName("valid_id")
                .HasColumnType("smallint(6)");
        }
    }
}
