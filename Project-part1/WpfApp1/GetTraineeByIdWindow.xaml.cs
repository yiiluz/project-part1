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
using Ex1_BL;
namespace Ex1_PL
{
    /// <summary>
    /// Interaction logic for GetTraineeByIdWindow.xaml
    /// </summary>
    public partial class GetTraineeByIdWindow : Window
    {
        private static BL bl = new BL();
        public GetTraineeByIdWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( bl.GetTraineeByID(int.Parse(Id.Text)).ToString());
        }
    }
}
