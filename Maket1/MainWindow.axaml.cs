using Avalonia.Controls;
using Avalonia.Interactivity;
using Maket1.Views;

namespace Maket1;

public partial class MainWindow : Window
{
    private readonly Button[] _nav;

    public MainWindow()
    {
        InitializeComponent();
        _nav = new[] { BtnOverview, BtnProjects, BtnTasks, BtnCalendar, BtnTeam, BtnSettings, BtnProfile };
        LoginScreen.LoggedIn += OnLoggedIn;
    }

    private void OnLoggedIn()
    {
        LoginScreen.IsVisible = false;
        AppScreen.IsVisible = true;
        BtnProfile.Content = "👤  " + AppState.FullName;
        Open(new OverviewPage(), BtnOverview);
    }

    // Показывает страницу и подсвечивает нужную кнопку меню
    private void Open(Control page, Button btn)
    {
        PageHost.Content = page;
        foreach (var b in _nav)
            b.Classes.Set("active", b == btn);
    }

    private void Logout_Click(object? sender, RoutedEventArgs e)
    {
        AppScreen.IsVisible = false;
        LoginScreen.IsVisible = true;
        LoginScreen.Reset();
    }

    private void Overview_Click(object? sender, RoutedEventArgs e) => Open(new OverviewPage(), BtnOverview);
    private void Projects_Click(object? sender, RoutedEventArgs e) => Open(new ProjectsPage(), BtnProjects);
    private void Tasks_Click(object? sender, RoutedEventArgs e) => Open(new TasksPage(), BtnTasks);
    private void Calendar_Click(object? sender, RoutedEventArgs e) => Open(new CalendarPage(), BtnCalendar);
    private void Team_Click(object? sender, RoutedEventArgs e) => Open(new TeamPage(), BtnTeam);
    private void Settings_Click(object? sender, RoutedEventArgs e) => Open(new SettingsPage(), BtnSettings);
    private void Profile_Click(object? sender, RoutedEventArgs e) => Open(new ProfilePage(), BtnProfile);
}