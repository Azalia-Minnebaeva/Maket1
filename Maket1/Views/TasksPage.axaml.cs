using Avalonia.Controls;
using Avalonia.Controls.Chrome;
using Avalonia.Interactivity;
using Maket1.Models;
using System;
using System.Diagnostics;

namespace Maket1.Views;

public partial class TasksPage : UserControl
{
    public TasksPage()
    {
        InitializeComponent();
        TaskList.ItemsSource = AppState.Tasks;
    }

    private void Add_Click(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TitleBox.Text)) return;

        string category = (CategoryBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Разработка";

        AppState.Tasks.Insert(0, new TaskItem
        {
            Title = TitleBox.Text.Trim(),
            Category = category,
            Date = DateTime.Now.ToString("dd.MM.yyyy")
        });
        TitleBox.Text = "";
    }

    private void Delete_Click(object? sender, RoutedEventArgs e)
    {
        if ((sender as Button)?.DataContext is TaskItem t)
            AppState.Tasks.Remove(t);
    }
}