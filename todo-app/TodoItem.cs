using System;

namespace todo_app;

public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}