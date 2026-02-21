using Domain.Common;
namespace Domain.Entities;

public class Cluster : BaseAuditableEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}
