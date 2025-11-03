using ELTE.ImageDownloader.View;
using ELTE.ImageDownloader.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ELTE.ImageDownloader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainViewModel _mainViewModel = null!;
        private MainWindow _mainWindow = null!;

        public App()
        {
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            _mainViewModel = new MainViewModel();
            _mainWindow = new MainWindow();
            _mainWindow.DataContext = _mainViewModel;
            _mainWindow.Show();
        }
    }
}
