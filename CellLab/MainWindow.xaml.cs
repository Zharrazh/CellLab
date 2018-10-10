using System;
using System.ComponentModel;
using System.Threading;
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
using System.Windows.Threading;

namespace CellLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public delegate void MyDelegate();

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
            Logic.process = Logic.InProcess.PAYSE;
            PauseBtn.Content = "Play";
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Logic.process == Logic.InProcess.PAYSE)
            {
                if (Logic.AliveCell > 8)
                {
                    Logic.NextDay();
                    Logic.Day++;
                    Day.Content = "Day: " + Logic.Day.ToString();
                }
                else
                {
                    Logic.Day = 0;
                    Day.Content = "Day:" + Logic.Day.ToString();
                    Logic.Era++;
                    Era.Content = "Era: " + Logic.Era.ToString();
                    Logic.NewGeneration();
                }
            }
        }

        private   void PauseBtn_Click(object sender, RoutedEventArgs e)
        {

                if (Logic.process == Logic.InProcess.PAYSE)
                {
                int MaxEra = Logic.Era + 500;

                        while(Logic.Era<MaxEra)
                        {
                            if (Logic.AliveCell > 8)
                            {
                                Logic.NextDay();
                                Logic.Day++;
                                Day.Content = "Day: " + Logic.Day.ToString();
                            }
                            else
                            {
                                Logic.Day = 0;
                                Day.Content = "Day:" + Logic.Day.ToString();
                                Logic.Era++;
                                Era.Content = "Era: " + Logic.Era.ToString();
                                Logic.NewGeneration();
                            }
                            
                        }
                       
                   


                }
               /* else
                {
                    Logic.process = Logic.InProcess.PAYSE;
                    PauseBtn.Content = "Pause";
                }*/
        }

        private void ChartBtn_Click(object sender, RoutedEventArgs e)
        {
            ChartWindow chartWindow = new ChartWindow();
            chartWindow.Show();
        }
    }
        

    
}
