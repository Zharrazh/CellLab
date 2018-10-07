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
    /// Логика взаимодействия для SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();


        }

        private void SettingWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void TextBox_food_TextChanged(object sender, TextChangedEventArgs e)
        {
            int i;
            if (Int32.TryParse(TextBox_food.Text, out i) && i >= 0 && i <= 100)
            {
                Slider_food.Value = i;
            }
        }

        private void TextBox_poison_TextChanged(object sender, TextChangedEventArgs e)
        {
            int i;
            if (Int32.TryParse(TextBox_poison.Text, out i) && i >= 0 && i <= 100)
            {
                Slider_poison.Value = i;
            }
        }

        private void TextBox_radiation_TextChanged(object sender, TextChangedEventArgs e)
        {
            int i;
            if (Int32.TryParse(TextBox_radiation.Text, out i) && i >= 0 && i <= 100)
            {
                Slider_radiation.Value = i;
            }
        }

        private void TextBox_foodNutrition_TextChanged(object sender, TextChangedEventArgs e)
        {
            int i;
            if (Int32.TryParse(TextBox_foodNutrition.Text, out i) && i >= 0 && i <= 100)
            {
                Slider_foodNutrition.Value = i;
            }

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            Logic.LoadSettings();
            Logic.LoadMap();
            Logic.RedrowMap();
            Visibility = Visibility.Hidden;
        }

        private void CanselBtn_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
        }

        
    }
}
