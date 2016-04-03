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
    /// Interaction logic for TabEditorWindow.xaml
    /// </summary>
    public partial class TabEditorWindow : Window
    {
        public TabEditorWindow()
        {
            InitializeComponent();
            AddMainUserControls();
        }

        private void AddMainUserControls()
        {
            UC_TopMenu topmenu = new UC_TopMenu();
            Grid.SetColumn(topmenu, 0);
            Grid.SetRow(topmenu, 0);
            grd_Main.Children.Add(topmenu);


            UC_GuitarBottom guitarBottom = new UC_GuitarBottom();
            Grid.SetColumn(guitarBottom, 0);
            Grid.SetRow(guitarBottom, 2);
            grd_Main.Children.Add(guitarBottom);

            UC_MultipleGuitars multipleGuitars = new UC_MultipleGuitars();
            Grid.SetColumn(multipleGuitars, 0);
            Grid.SetRow(multipleGuitars, 0);
            grd_Middle.Children.Add(multipleGuitars);

            UC_NotesChordsScales notesChordsScales = new UC_NotesChordsScales();
            Grid.SetColumn(notesChordsScales, 2);
            Grid.SetRow(notesChordsScales, 0);
            grd_Middle.Children.Add(notesChordsScales);



            UC_EditorView editorView = new UC_EditorView();
            Grid.SetColumn(editorView, 1);
            Grid.SetRow(editorView, 0);
            grd_Middle.Children.Add(editorView);


        }
    }
}
