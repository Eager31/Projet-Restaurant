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

namespace Restaurant_Code
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windowMain = new MainWindow();
            windowMain.Owner = this;
            windowMain.ShowDialog();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Owner = this;
            window2.ShowDialog();
        }
    }
}
