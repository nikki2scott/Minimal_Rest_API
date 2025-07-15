// Reminder: DTO stands for data transfer object
using TodoApi.Models;

public class TodoItemDTO
{
    private int _id;
    public int Id
    {
        get { return _id; }
    }

    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (_id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);
}