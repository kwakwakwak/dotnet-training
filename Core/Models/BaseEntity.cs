using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class BaseEntity<TKey>
{
    [Key]
    public required TKey Id { get; set; }
}
