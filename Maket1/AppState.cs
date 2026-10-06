using System.Collections.ObjectModel;
using Maket1.Models;

namespace Maket1;

public static class AppState
{
    public const string ValidLogin = "admin";
    public const string ValidPassword = "12345";

    // ВПИШИ СВОЁ ФИО
    public static string FullName = "Миннебаева Азалия Рамилевна";

    public static ObservableCollection<Project> Projects = new()
    {
        new Project { Name = "Avalonia UI Redesign", Category = "Дизайн", Progress = 65 },
        new Project { Name = "Мобильное приложение", Category = "Разработка", Progress = 40 },
        new Project { Name = "Корпоративный сайт", Category = "Разработка", Progress = 80 },
    };

    public static ObservableCollection<TaskItem> Tasks = new()
    {
        new TaskItem { Title = "Разработать макет главной страницы", Category = "Дизайн", Date = "15.05.2024" },
        new TaskItem { Title = "Реализовать авторизацию", Category = "Разработка", Date = "14.05.2024" },
        new TaskItem { Title = "Подготовить презентацию", Category = "Маркетинг", Date = "13.05.2024" },
    };

    public static ObservableCollection<Member> Team = new()
    {
        new Member { Name = "Миннебаева Азалия", Role = "Руководитель проекта" },
        new Member { Name = "Галямова Аделина", Role = "Дизайнер" },
        new Member { Name = "Гайсина Арина", Role = "Разработчик" },
        new Member { Name = "Уразова Злата", Role = "Маркетолог" },
    };
}