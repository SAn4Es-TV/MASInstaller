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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace MASInstaller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flag = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        #region ------ ЛОГИКА ОКНА ------
        // Движение мышкой
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        // Скрываем окно
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Закрываем окно
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            if (!flag)
            {
                buttonAnimation.From = this.ActualHeight;
                buttonAnimation.To = 600;
                buttonAnimation.Duration = TimeSpan.FromMilliseconds(200);
            }
            else
            {
                buttonAnimation.From = this.ActualHeight;
                buttonAnimation.To = 450;
                buttonAnimation.Duration = TimeSpan.FromMilliseconds(200);
            }
            flag = !flag;
            this.BeginAnimation(MainWindow.HeightProperty, buttonAnimation);
        }

        private void ChangePath_Click(object sender, RoutedEventArgs e)
        {
            //FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            /*if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                pathToInstall.Text = folderBrowser.SelectedPath;*/
        }
    }
}
