namespace Core.Models;

public class Todo : BaseEntity<int>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; }
}
