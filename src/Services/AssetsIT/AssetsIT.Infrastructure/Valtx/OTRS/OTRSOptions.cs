namespace AssetsIT.Infrastructure.Valtx.OTRS
{
    public class OTRSOptions
    {
        public string StolenAlertTicketTitle { get; set; }
        public string TicketTypeIncidence { get; set; }
        public string TicketTypeRequeriment { get; set; }
        public string StoleAlertTicketEmailSubject { get; set; }

        public string TicketPriorityLow { get; set; }
        public string TicketStateNew { get; set; }
        
        public string TicketArticleSubjectNoRenew { get; set; }
        public string TicketArticleSubjectUpdate { get; set; }

        public string AssetDeploymentStateStolen { get; set; }

        public string UserStaffTerminationNotification { get; set; }
        public string UserStaffTerminationNotificationToAdministrator { get; set; }
        public string UserStaffTerminationNotRenewNotificationToAdministrator { get; set; }

        public string StolenAlertQueueName { get; set; }
        public string AssetReturnQueueName { get; set; }
        public string TicketIncidenceQueueName { get; set; }

    }
}
