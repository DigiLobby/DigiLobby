namespace Domain.Common;

public class BaseAuditableEntity : BaseEntity
{
    public string? CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedAt { get; set; }

    public string? LastModifiedBy { get; set; } = null!;

    public DateTimeOffset LastModifiedAt { get; set; }
}
