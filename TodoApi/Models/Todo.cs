
namespace TodoApi.Models;

/// <summary>
/// Todo model
/// A model is a class that represents data that the app manages.
/// </summary>
public class Todo
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}

