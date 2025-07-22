using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models;

public class BaseEntity
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    
}