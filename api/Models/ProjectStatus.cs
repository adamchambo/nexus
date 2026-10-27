using Nexus.Api.Models.Enums;

namespace Nexus.Api.Models;

public class ProjectStatus
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }
    public required string Name { get; set; }
    public int Position { get; set; }
    public TaskStatusCategory Category { get; set; }
}
