using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Maket1.Views;

public partial class LoginView : UserControl
{
    public event Action? LoggedIn;

    public LoginView()
    {
        InitializeComponent();
    }

    private void Login_Click(object? sender, RoutedEventArgs e)
    {
        bool ok = LoginBox.Text == AppState.ValidLogin
               && PasswordBox.Text == AppState.ValidPassword;

        ErrorText.IsVisible = !ok;

        if (ok)
            LoggedIn?.Invoke();
    }

    public void Reset()
    {
        LoginBox.Text = "";
        PasswordBox.Text = "";
        ErrorText.IsVisible = false;
    }
}