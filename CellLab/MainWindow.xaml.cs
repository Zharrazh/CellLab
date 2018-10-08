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

namespace CellLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Label[] CellsLabels;
        //public Rectangle[] CellsRects;
        //public ToolTip[] CellToolTips;
        SettingWindow settingWindow;
        public Rectangle[,] rectangles;
        public MainWindow()
        {
            InitializeComponent();

            settingWindow = new SettingWindow();

            Logic.MW = this;
            Logic.SW = settingWindow;
            
            Logic.LoadSettings();
            Logic.LoadMap();
            //Logic.DrawMap();
            Logic.RedrowMap();
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {
            settingWindow.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
            settingWindow.Close();
            Application.Current.Shutdown();
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Logic.SIZE = (int)((Slider)sender).Value;
            Logic.RedrowMap();
            if (Logic.cells != null)
            {
                for(int i = 0; i < 64; i++)
                {
                    if (Logic.cells[i] != null)
                    {
                        Logic.cells[i].Draw();
                    }
                }
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Logic.StartPoison();
            Logic.StartFood();
            Logic.DrawWalls();
            Logic.StartGeneration();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            Logic.NextDay();
        }
    }
}
