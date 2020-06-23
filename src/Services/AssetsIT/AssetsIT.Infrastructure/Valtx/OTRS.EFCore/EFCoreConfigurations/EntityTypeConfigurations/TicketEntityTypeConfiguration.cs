using AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreConfigurations.EntityTypeConfigurations
{
    public class TicketEntityTypeConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("ticket");

            builder.HasIndex(e => e.ArchiveFlag)
                .HasName("ticket_archive_flag");

            builder.HasIndex(e => e.ChangeBy)
                .HasName("FK_ticket_change_by_id");

            builder.HasIndex(e => e.CreateBy)
                .HasName("FK_ticket_create_by_id");

            builder.HasIndex(e => e.CreateTime)
                .HasName("ticket_create_time");

            builder.HasIndex(e => e.CreateTimeUnix)
                .HasName("ticket_create_time_unix");

            builder.HasIndex(e => e.CustomerId)
                .HasName("ticket_customer_id");

            builder.HasIndex(e => e.CustomerUserId)
                .HasName("ticket_customer_user_id");

            builder.HasIndex(e => e.EscalationResponseTime)
                .HasName("ticket_escalation_response_time");

            builder.HasIndex(e => e.EscalationSolutionTime)
                .HasName("ticket_escalation_solution_time");

            builder.HasIndex(e => e.EscalationTime)
                .HasName("ticket_escalation_time");

            builder.HasIndex(e => e.EscalationUpdateTime)
                .HasName("ticket_escalation_update_time");

            builder.HasIndex(e => e.QueueId)
                .HasName("ticket_queue_id");

            builder.HasIndex(e => e.ResponsibleUserId)
                .HasName("ticket_responsible_user_id");

            builder.HasIndex(e => e.ServiceId)
                .HasName("FK_ticket_service_id_id");

            builder.HasIndex(e => e.SlaId)
                .HasName("FK_ticket_sla_id_id");

            builder.HasIndex(e => e.TicketLockId)
                .HasName("ticket_ticket_lock_id");

            builder.HasIndex(e => e.TicketPriorityId)
                .HasName("ticket_ticket_priority_id");

            builder.HasIndex(e => e.TicketStateId)
                .HasName("ticket_ticket_state_id");

            builder.HasIndex(e => e.Timeout)
                .HasName("ticket_timeout");

            builder.HasIndex(e => e.Title)
                .HasName("ticket_title");

            builder.HasIndex(e => e.Tn)
                .HasName("ticket_tn")
                .IsUnique();

            builder.HasIndex(e => e.TypeId)
                .HasName("ticket_type_id");

            builder.HasIndex(e => e.UntilTime)
                .HasName("ticket_until_time");

            builder.HasIndex(e => e.UserId)
                .HasName("ticket_user_id");

            builder.HasIndex(e => new { e.TicketStateId, e.TicketLockId })
                .HasName("ticket_queue_view");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("bigint(20)");

            builder.Property(e => e.ArchiveFlag)
                .HasColumnName("archive_flag")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.ChangeBy)
                .HasColumnName("change_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.ChangeTime).HasColumnName("change_time");

            builder.Property(e => e.CreateBy)
                .HasColumnName("create_by")
                .HasColumnType("int(11)");

            builder.Property(e => e.CreateTime).HasColumnName("create_time");

            builder.Property(e => e.CreateTimeUnix)
                .HasColumnName("create_time_unix")
                .HasColumnType("bigint(20)");

            builder.Property(e => e.CustomerId)
                .HasColumnName("customer_id")
                .HasColumnType("varchar(150)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.CustomerUserId)
                .HasColumnName("customer_user_id")
                .HasColumnType("varchar(250)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.EscalationResponseTime)
                .HasColumnName("escalation_response_time")
                .HasColumnType("int(11)");

            builder.Property(e => e.EscalationSolutionTime)
                .HasColumnName("escalation_solution_time")
                .HasColumnType("int(11)");

            builder.Property(e => e.EscalationTime)
                .HasColumnName("escalation_time")
                .HasColumnType("int(11)");

            builder.Property(e => e.EscalationUpdateTime)
                .HasColumnName("escalation_update_time")
                .HasColumnType("int(11)");

            builder.Property(e => e.QueueId)
                .HasColumnName("queue_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ResponsibleUserId)
                .HasColumnName("responsible_user_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.ServiceId)
                .HasColumnName("service_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.SlaId)
                .HasColumnName("sla_id")
                .HasColumnType("int(11)");

            builder.Property(e => e.TicketLockId)
                .HasColumnName("ticket_lock_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.TicketPriorityId)
                .HasColumnName("ticket_priority_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.TicketStateId)
                .HasColumnName("ticket_state_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.Timeout)
                .HasColumnName("timeout")
                .HasColumnType("int(11)");

            builder.Property(e => e.Title)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.Tn)
                .IsRequired()
                .HasColumnName("tn")
                .HasColumnType("varchar(50)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            builder.Property(e => e.TypeId)
                .HasColumnName("type_id")
                .HasColumnType("smallint(6)");

            builder.Property(e => e.UntilTime)
                .HasColumnName("until_time")
                .HasColumnType("int(11)");

            builder.Property(e => e.UserId)
                .HasColumnName("user_id")
                .HasColumnType("int(11)");
        }
    }
}
