using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Building> Buildings { get; }
    DbSet<Cluster> Clusters { get; }

    // Many-to-many tables
    DbSet<ClusterAdmin> ClusterAdmins { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
