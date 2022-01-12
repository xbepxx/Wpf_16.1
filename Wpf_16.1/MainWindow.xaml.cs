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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_16._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 150;
            doubleAnimation.To = 500;
            //doubleAnimation.By = 50;
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(6));
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(2);
            //doubleAnimation.AccelerationRatio = 1;
            doubleAnimation.SpeedRatio = 2;
            //doubleAnimation.AutoReverse = true;
            doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
            btn.BeginAnimation(Button.HeightProperty, doubleAnimation);

            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red;
            colorAnimation.To = Colors.Blue;
            colorAnimation.Duration= TimeSpan.FromSeconds(2);
            btn.Background = new SolidColorBrush(Colors.Red);
            btn.Background.BeginAnimation(SolidColorBrush.ColorProperty,colorAnimation);

        }
    }
}
