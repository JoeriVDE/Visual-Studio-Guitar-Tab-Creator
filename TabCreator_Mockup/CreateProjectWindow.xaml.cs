using Microsoft.Win32;
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

namespace TabCreator_Mockup
{
    /// <summary>
    /// Interaction logic for CreateProjectWindow.xaml
    /// </summary>
    public partial class CreateProjectWindow : Window
    {
        private string NonAssignedFieldMessage = "Please Assign this field";
        private SolidColorBrush originalColor;

        public CreateProjectWindow()
        {
            InitializeComponent();
            originalColor = (SolidColorBrush)this.FindResource("Aqua_Soft");
        }


        private void CancelCreateProject(object sender, RoutedEventArgs REA)
        {
            new StartWindow().Show();
            this.Close();
        }

        private void ResetColor(object sender, RoutedEventArgs e)
        {
            TextBox selectedTB = sender as TextBox;

            if (selectedTB != null)
            {
                if(string.IsNullOrWhiteSpace(selectedTB.Text) || selectedTB.Text == NonAssignedFieldMessage)
                    selectedTB.Text = string.Empty;
                selectedTB.Foreground = originalColor;
            }
        }

        private void CreateProject(object sender, RoutedEventArgs REA)
        {
            bool informationFilledIn = false;

            List<TextBox> nonFilledTextBoxes = new List<TextBox>();

            if (string.IsNullOrWhiteSpace(txt_Title.Text) || txt_Title.Text == NonAssignedFieldMessage)
            {
                txt_Title.Text = NonAssignedFieldMessage;
                nonFilledTextBoxes.Add(txt_Title);
            }

            if (string.IsNullOrWhiteSpace(txt_File_Path.Text) || txt_File_Path.Text == NonAssignedFieldMessage)
            {
                txt_File_Path.Text = NonAssignedFieldMessage;
                nonFilledTextBoxes.Add(txt_File_Path);
            }

            if (string.IsNullOrWhiteSpace(txt_BPM.Text) || txt_BPM.Text == NonAssignedFieldMessage)
            {
                txt_BPM.Text = NonAssignedFieldMessage;
                nonFilledTextBoxes.Add(txt_BPM);
            }

            if (!string.IsNullOrWhiteSpace(txt_BPM.Text) || txt_BPM.Text != NonAssignedFieldMessage
                && !string.IsNullOrWhiteSpace(txt_File_Path.Text) || txt_File_Path.Text != NonAssignedFieldMessage
                && !string.IsNullOrWhiteSpace(txt_BPM.Text) || txt_BPM.Text != NonAssignedFieldMessage
                ) informationFilledIn = true;

            if (informationFilledIn)
            {
                new TabEditorWindow().Show();
                this.Close();                
            } else
            {
                foreach (TextBox txtBox in nonFilledTextBoxes)
                {
                    txtBox.Foreground = new SolidColorBrush(Color.FromRgb(255,0,0));
                }
            }
        }

        private void btn_OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                txt_File_Path.Text = dlg.FileName;
            }
        }
    }

}
