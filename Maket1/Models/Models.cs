namespace Maket1.Models;

public class Project
{
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public int Progress { get; set; }
}

public class TaskItem
{
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public string Date { get; set; } = "";
    public bool IsDone { get; set; }
}

public class Member
{
    public string Name { get; set; } = "";
    public string Role { get; set; } = "";
    public string Initial => string.IsNullOrEmpty(Name) ? "" : Name.Substring(0, 1);
}
