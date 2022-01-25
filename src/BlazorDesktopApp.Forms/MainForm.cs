using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            App.SetupServices(serviceCollection);

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }
    }
}