using Domain.Entities.Common;

namespace Domain.Entities;

public class ClusterAdmin : AuditableEntity
{
    public required string ClusterId { get; set; }
    public Cluster Cluster { get; set; } = null!;

    public required string AdminId { get; set; }
    public ApplicationUser Admin { get; set; } = null!;
}
