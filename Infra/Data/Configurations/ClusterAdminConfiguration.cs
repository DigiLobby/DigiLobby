using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class ClusterAdminConfiguration : IEntityTypeConfiguration<ClusterAdmin>
{
    public void Configure(EntityTypeBuilder<ClusterAdmin> builder)
    {
        builder.HasKey(e => new { e.ClusterId, e.AdminId });
    }
}
