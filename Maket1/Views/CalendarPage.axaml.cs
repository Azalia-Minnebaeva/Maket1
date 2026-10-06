using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace Maket1.Views;

public partial class CalendarPage : UserControl
{
    private static readonly string[] MonthNames =
    {
        "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
        "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
    };

    private DateTime _month = new DateTime(2024, 5, 1);
    private DateTime _selected = new DateTime(2024, 5, 15);

    public CalendarPage()
    {
        InitializeComponent();
        Build();
    }

    private void Build()
    {
        DaysGrid.Children.Clear();
        MonthTitle.Text = MonthNames[_month.Month - 1] + " " + _month.Year;
        SelectedText.Text = "Выбрано: " + _selected.ToString("dd.MM.yyyy");

        string[] heads = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        foreach (var h in heads)
        {
            DaysGrid.Children.Add(new TextBlock
            {
                Text = h,
                Opacity = 0.6,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(0, 4)
            });
        }

        int offset = ((int)_month.DayOfWeek + 6) % 7;
        for (int i = 0; i < offset; i++)
            DaysGrid.Children.Add(new TextBlock());

        int count = DateTime.DaysInMonth(_month.Year, _month.Month);
        for (int day = 1; day <= count; day++)
        {
            var date = new DateTime(_month.Year, _month.Month, day);
            var btn = new Button { Content = day.ToString(), Tag = date };
            btn.Classes.Add("day");
            if (date == _selected)
                btn.Classes.Add("sel");
            btn.Click += Day_Click;
            DaysGrid.Children.Add(btn);
        }
    }

    private void Day_Click(object? sender, RoutedEventArgs e)
    {
        if (sender is Button { Tag: DateTime date })
        {
            _selected = date;
            Build();
        }
    }

    private void Prev_Click(object? sender, RoutedEventArgs e)
    {
        _month = _month.AddMonths(-1);
        Build();
    }

    private void Next_Click(object? sender, RoutedEventArgs e)
    {
        _month = _month.AddMonths(1);
        Build();
    }
}