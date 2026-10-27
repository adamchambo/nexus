using Nexus.Api.Models.Enums;

namespace Nexus.Api.Models;

public class WorkspaceMember
{
    public Guid Id { get; set; }
    public Guid WorkspaceId { get; set; }
    public Guid UserId { get; set; }
    public WorkspaceRole Role { get; set; }
    public DateTimeOffset JoinedAt { get; set; }
}
