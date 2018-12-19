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
using Ex1_BE;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for WindowTester.xaml
    /// </summary>
    public partial class WindowTester : Window
    {
        public WindowTester()
        {

            InitializeComponent();
            theNewTester = new Tester();
        }
        Tester theNewTester;
        private void IDinput(object sender, TextCompositionEventArgs e)
        {
              Int32.TryParse(ID.Text, out theNewTester.id);
        }
    }
}