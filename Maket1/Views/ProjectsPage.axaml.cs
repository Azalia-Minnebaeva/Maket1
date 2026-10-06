using Avalonia.Controls;
using Avalonia.Interactivity;
using Maket1.Models;

namespace Maket1.Views;

public partial class ProjectsPage : UserControl
{
    public ProjectsPage()
    {
        InitializeComponent();
        ProjectList.ItemsSource = AppState.Projects;
    }

    private void Add_Click(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameBox.Text)) return;

        string category = (CategoryBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Разработка";

        AppState.Projects.Add(new Project
        {
            Name = NameBox.Text.Trim(),
            Category = category,
            Progress = 0
        });
        NameBox.Text = "";
    }

    private void Delete_Click(object? sender, RoutedEventArgs e)
    {
        if ((sender as Button)?.DataContext is Project p)
            AppState.Projects.Remove(p);
    }
}