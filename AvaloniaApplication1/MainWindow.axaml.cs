using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace AvaloniaApplication1;
public partial class MainWindow : Window
{

    public MainWindow()
    {
        DataContext = new ViewModel();
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
    }

    private void Button_GC_Click(object? sender, RoutedEventArgs e)
    {
        GC.Collect();
    }
}

public class ViewModel
{
    ~ViewModel()
    {
        Debug.WriteLine("Finalized called");
    }

    private readonly byte[] someData = new byte[65536];

}