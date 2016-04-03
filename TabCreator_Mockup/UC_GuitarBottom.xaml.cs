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
    /// Interaction logic for GuitarBottom.xaml
    /// </summary>
    public partial class UC_GuitarBottom : UserControl
    {
        private SolidColorBrush brownColor;

        public UC_GuitarBottom()
        {
            InitializeComponent();

            brownColor = (SolidColorBrush) Application.Current.FindResource("Brown_Guitar");

            AddGuitarSections(23, 5);
        }

        private void AddGuitarSections(int x, int y)
        {
            ColumnDefinition colDef = new ColumnDefinition();
            RowDefinition rowDef = new RowDefinition();
            GridLength gl = new GridLength(1, GridUnitType.Star);

            colDef.Width = gl;

            for (int i = 0; i < y; i++)
            {
                rowDef = new RowDefinition();
                rowDef.Height = gl;
                grd_Guitar.RowDefinitions.Add(rowDef);
            }

            for (int i = 0; i < x; i++)
            {
                colDef = new ColumnDefinition();
                colDef.Width = gl;
                grd_Guitar.ColumnDefinitions.Add(colDef);
            }

            for (int row = 0; row < grd_Guitar.RowDefinitions.Count; row++)
            {
                for(int column = 0; column < grd_Guitar.ColumnDefinitions.Count; column++)
                {
                    Button b = new Button();
                    //Color newColor = new Color();
                    //newColor.A = 0;
                    b.Background = brownColor;
                    b.Width = 5;

                    b.HorizontalAlignment = HorizontalAlignment.Left;

                    b.SetValue(Grid.RowProperty, row);
                    b.SetValue(Grid.ColumnProperty, column);

                    grd_Guitar.Children.Add(b);
                }
            }

            Grid.SetColumnSpan(img_GuitarBg, x);
            Grid.SetRowSpan(img_GuitarBg, y);
            
        }
    }
}
