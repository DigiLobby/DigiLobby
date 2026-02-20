using Domain.Entities.Common;

namespace Domain.Entities;

public class Building : AuditableEntity
{
    public required string ClusterId { get; set; }
    public Cluster Cluster { get; set; } = null!;

    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
    public required string Country { get; set; }
    public string? Description { get; set; }

}
