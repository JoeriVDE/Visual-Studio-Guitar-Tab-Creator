using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TabCreator_Mockup
{
    /// <summary>
    /// Interaction logic for LoadProject.xaml
    /// </summary>
    public partial class LoadProject : Window
    {
        public LoadProject()
        {
            InitializeComponent();
        }

        private void btn_Canel_Click(object sender, RoutedEventArgs e)
        {
            new StartWindow().Show();
            this.Close();
        }

        private void btn_LoadProject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Momenteel nog niet beschikbaar ;)");
        }

        private void btn_OpenExplorer_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                txt_FilePath.Text = dlg.FileName;                    
            }            
        }
    }
}
