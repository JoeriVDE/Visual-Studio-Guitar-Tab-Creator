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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TabCreator_Mockup
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Close_Application(object sender, RoutedEventArgs REA)
        {
            Application.Current.Shutdown();
        }

        private void CreateProject(object sender, RoutedEventArgs REA)
        {
           new CreateProjectWindow().Show();
            CloseThisWindow();
        }

        private void btn_OpenProject_Click(object sender, RoutedEventArgs e)
        {
            new LoadProject().Show();
            CloseThisWindow();
        }

        private void CloseThisWindow()
        {
            this.Close();
        }
    }
}
