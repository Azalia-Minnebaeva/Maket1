using Avalonia.Controls;

namespace Maket1.Views;

public partial class ProfilePage : UserControl
{
    public ProfilePage()
    {
        InitializeComponent();
        NameText.Text = AppState.FullName;
        LoginText.Text = "Логин: " + AppState.ValidLogin;
        InitialText.Text = AppState.FullName.Substring(0, 1);
    }
}