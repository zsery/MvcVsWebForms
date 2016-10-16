namespace Interfaces
{
    public interface IEVENT
    {
        int EventId { get; set; }

        int IsirId { get; set; }

        System.Nullable<int> CaseId { get; set; }

        string CaseSign { get; set; }

        System.DateTime PublishedAt { get; set; }

        System.DateTime LoadedAt { get; set; }

        System.Nullable<System.DateTime> SavedAt { get; set; }

        System.Nullable<System.DateTime> LegalCaseIniatedAt { get; set; }

        System.Nullable<System.DateTime> ResolvedAt { get; set; }

        string Resolver { get; set; }

        int EventTypeId { get; set; }

        string EventTypDescription { get; set; }

        string Section { get; set; }

        System.Nullable<int> OrderOfSection { get; set; }

        string IDUser { get; set; }

        System.Nullable<System.DateTime> CanceledAt { get; set; }

        System.Nullable<int> RiskCode { get; set; }

        System.Nullable<int> EventStateId { get; set; }

        string VerifiedBy { get; set; }

        System.Nullable<System.DateTime> VerifiedAt { get; set; }

        System.DateTime ModifiedAt { get; set; }
    }
}