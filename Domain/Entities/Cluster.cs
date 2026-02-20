using Domain.Entities.Common;

namespace Domain.Entities;

public class Cluster : AuditableEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}
