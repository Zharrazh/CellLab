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

namespace CellLab
{
    /// <summary>
    /// Логика взаимодействия для InfoWin.xaml
    /// </summary>
    public partial class InfoWin : Window
    {
        public InfoWin()
        {
            InitializeComponent();

            gensLabels = new Label[64];
            for (int i = 0; i < 64; i++)
            {
                gensLabels[i] = new Label { VerticalContentAlignment = System.Windows.VerticalAlignment.Center, HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center, BorderThickness = new System.Windows.Thickness(1), BorderBrush = Brushes.Black };
                Genome.Children.Add(gensLabels[i]);
            }
        }
        public Label[] gensLabels;
        
    }
}
