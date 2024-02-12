using CommunityToolkit.Mvvm.Messaging;
using Core;
using Core.Localization;
using Core.Messages;
using Core.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using MusicSteak.Views;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace MusicSteak
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();

            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static ServiceProvider ConfigureServices()
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            var l = currentCulture.Name[0..2];
            var language = new Language
            {
                Current = l switch
                {
                    "en" => Lang.English,
                    "cs" => Lang.Czech,
                    _ => throw new NotImplementedException()
                }
            };

            var services = new ServiceCollection()
                .AddSingleton<IMessenger, StrongReferenceMessenger>()
                .AddSingleton(typeof(HistoryViewModel))
                .AddSingleton(typeof(MainViewModel))
                .AddSingleton(typeof(Language), language);

            return services.BuildServiceProvider();
        }
    }
}
