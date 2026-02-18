namespace Domain.Entities.Common;

public class AuditableEntity : BaseEntity
{
    public string? CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedAt { get; set; }

    public string? LastModifiedBy { get; set; } = null!;

    public DateTimeOffset LastModifiedAt { get; set; }
}
