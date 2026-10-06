using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;

namespace Maket1.Views;

public partial class OverviewPage : UserControl
{
    public OverviewPage()
    {
        InitializeComponent();
        BuildCalendar();
    }

    private void BuildCalendar()
    {
        string[] days = { "Ïí", "Âò", "Ñð", "×ò", "Ïò", "Ñá", "Âñ" };
        foreach (var d in days)
        {
            CalendarGrid.Children.Add(new TextBlock
            {
                Text = d,
                FontSize = 11,
                Opacity = 0.6,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 4)
            });
        }

        var first = new DateTime(2024, 5, 1);
        int offset = ((int)first.DayOfWeek + 6) % 7;
        for (int i = 0; i < offset; i++)
            CalendarGrid.Children.Add(new TextBlock());

        int count = DateTime.DaysInMonth(2024, 5);
        for (int day = 1; day <= count; day++)
        {
            if (day == 15)
            {
                CalendarGrid.Children.Add(new Border
                {
                    Width = 26,
                    Height = 26,
                    CornerRadius = new CornerRadius(13),
                    Background = new SolidColorBrush(Color.Parse("#6C4DE6")),
                    Child = new TextBlock
                    {
                        Text = day.ToString(),
                        FontSize = 12,
                        Foreground = Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    }
                });
            }
            else
            {
                CalendarGrid.Children.Add(new TextBlock
                {
                    Text = day.ToString(),
                    FontSize = 12,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Margin = new Thickness(0, 6)
                });
            }
        }
    }
}