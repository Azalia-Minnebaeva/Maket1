using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace Maket1.Views;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();
        ThemeSwitch.IsChecked = Application.Current!.ActualThemeVariant == ThemeVariant.Dark;
    }

    private void Theme_Changed(object? sender, RoutedEventArgs e)
    {
        Application.Current!.RequestedThemeVariant =
            ThemeSwitch.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}