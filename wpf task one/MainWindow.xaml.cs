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

namespace wpf_task_one
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {





            //if (x != null)
            //{
            //    x.Dispose();
            //    x = null;
            //}


            if (sender is Button bt)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
                bt.Background = brush;
                MessageBox.Show(bt.Content.ToString());
            }
        }



        private void button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

          if(sender is Button bt) 
           {
                //Panel1.Children.Remove(bt);
                //grid1.Children.Remove(bt );
                grid1.Children.Clear();

            }







        }
    }
}
