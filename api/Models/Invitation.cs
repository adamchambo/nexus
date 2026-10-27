using Nexus.Api.Models.Enums;

namespace Nexus.Api.Models;

public class Invitation
{
    public Guid Id { get; set; }
    public Guid WorkspaceId { get; set; }
    public required string Email { get; set; }
    public WorkspaceRole Role { get; set; }
    public Guid InvitedByMemberId { get; set; }
    public required string TokenHash { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset ExpiresAt { get; set; }
    public DateTimeOffset? AcceptedAt { get; set; }
    public DateTimeOffset? RevokedAt { get; set; }
}
