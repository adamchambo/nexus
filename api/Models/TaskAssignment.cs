namespace Nexus.Api.Models;

public class TaskAssignment
{
    public Guid TaskId { get; set; }
    public Guid WorkspaceMemberId { get; set; }
    public DateTimeOffset AssignedAt { get; set; }
}
