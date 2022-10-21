using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UpdaterManager.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        private ProgramView programView;
        private LauncherView launcherView;
        private UpdaterView updaterView;
        public MainWindowView()
        {
            InitializeComponent();
            programView = new ProgramView();
            launcherView = new LauncherView();
            updaterView = new UpdaterView();
            frame.Navigate(programView);
        }

        private void toProgram(object sender, RoutedEventArgs e)
        {
            frame.Navigate(programView);
        }

        private void toLauncher(object sender, RoutedEventArgs e)
        {
            frame.Navigate(launcherView);
        }

        private void toUpdater(object sender, RoutedEventArgs e)
        {
            frame.Navigate(updaterView);
        }
    }
}
