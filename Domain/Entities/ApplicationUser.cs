using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public required string DisplayName { get; set; }
    public bool IsDisabled { get; set; }

    public string? BuildingId { get; set; }
    public Building? Building { get; set; }
}