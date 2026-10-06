using Avalonia.Controls;
using Avalonia.Interactivity;
using Maket1.Models;
using System.Diagnostics;

namespace Maket1.Views;

public partial class TeamPage : UserControl
{
    public TeamPage()
    {
        InitializeComponent();
        TeamList.ItemsSource = AppState.Team;
    }

    private void Add_Click(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameBox.Text)) return;

        AppState.Team.Add(new Member
        {
            Name = NameBox.Text.Trim(),
            Role = string.IsNullOrWhiteSpace(RoleBox.Text) ? "Участник" : RoleBox.Text.Trim()
        });
        NameBox.Text = "";
        RoleBox.Text = "";
    }

    private void Delete_Click(object? sender, RoutedEventArgs e)
    {
        if ((sender as Button)?.DataContext is Member m)
            AppState.Team.Remove(m);
    }
}