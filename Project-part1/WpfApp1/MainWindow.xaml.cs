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
using Ex1_BE;
using Ex1_BL;
namespace Ex1_PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool isAddTraineeWindowOpen = true;
        public MainWindow()
        {
            InitializeComponent();
        }
        BL bl = new BL();
        private void Button_Click_AddTrainee(object sender, RoutedEventArgs e)
        {
            Trainee trainee = new Trainee();
            AddTraineeWindow addTraineeWindow = new AddTraineeWindow();
            addTraineeWindow.Show();
        }

        private void Button_Click_GetTraineeByID(object sender, RoutedEventArgs e)
        {
            GetTraineeByIdWindow getTraineeByIdWindow = new GetTraineeByIdWindow();
            getTraineeByIdWindow.Show();
        }
    }
}
