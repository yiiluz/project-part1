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

        private void Button_Click_AddTrainee(object sender, RoutedEventArgs e)
        {
            Trainee trainee = new Trainee();
            AddTraineeWindow addTraineeWindow = new AddTraineeWindow();
            addTraineeWindow.Show();
            //int numOfErrors = 1;
            //string errorList = "";


            //    bool ok = true;
            //    DateTime dateOfBirth, lastTest;
            //    string lastName, firstName, schoolName, teacherName;
            //    int id, phoneNumber, buildingNumber, numOfFinishedLessons, numOfTests;
            //    Address address;

            //    while (isAddTraineeWindowOpen) ;

            //    ok = int.TryParse(addTraineeWindow.ID.ToString(), out id);
            //    if (!ok)
            //    {
            //        errorList += numOfErrors++;
            //        errorList += ". Cant convert Id input to int.\n";
            //        ok = true;
            //    }
            //    firstName = addTraineeWindow.FirstName.ToString();
            //    lastName = addTraineeWindow.LastName.ToString();

            //    ok = DateTime.TryParse(addTraineeWindow.BirthDate.ToString(), out dateOfBirth);
            //    if (!ok)
            //    {
            //        errorList += numOfErrors++;
            //        errorList += ". Cant convert Birth-Date input to DateTime object.\n";
            //        ok = true;
            //    }

            //    ok = int.TryParse(addTraineeWindow.PhoneNumber.ToString(), out phoneNumber);
            //    if (!ok)
            //    {
            //        errorList += numOfErrors++;
            //        errorList += ". Cant convert Phone number input to int.\n";
            //        ok = true;
            //    }

            //    ok = int.TryParse(addTraineeWindow.BuildingNumber.ToString(), out buildingNumber);
            //    if (!ok)
            //    {
            //        errorList += numOfErrors++;
            //        errorList += ". Cant convert building number input to int.\n";
            //        ok = true;
            //    }
            //    else
            //        address = new Address(addTraineeWindow.City.ToString(), addTraineeWindow.Street.ToString(), buildingNumber);
            //    schoolName = addTraineeWindow.SchoolName.ToString();
            //    teacherName = addTraineeWindow.TeacherName.ToString();

            //    ok = int.TryParse(addTraineeWindow.NumOfLessons.ToString(), out numOfFinishedLessons);
            //    if (!ok)
            //    {
            //        errorList += numOfErrors++;
            //        errorList += ". Cant convert number of lessons input to int.\n";
            //        ok = true;
            //    }

            //    ok = int.TryParse(addTraineeWindow.NumOfTests.ToString(), out numOfTests);
            //    if (!ok)
            //    {
            //        errorList += numOfErrors++;
            //        errorList += ". Cant convert building number input to int.\n";
            //        ok = true;
            //    }
            //}

            //if (addTraineeWindow.isDidTest.GetValue())
            // bool isAlreadyDidTest;


            //public List<CarTypeEnum> existingLicenses;

        }
    }
}
