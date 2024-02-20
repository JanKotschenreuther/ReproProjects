using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Windows;

namespace WpfBlazorHybridApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IHost _host;

    public MainWindow()
    {
        InitializeComponent();

        var builder = Host.CreateApplicationBuilder();

        builder.Services.AddWpfBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        _host = builder.Build();

        Resources.Add("services", _host.Services);
    }
}