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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddTraineeWindow : Window
    {
        public AddTraineeWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Trainee trainee = new Trainee();
            this.Close();
            int numOfErrors = 1;
            string errorList = "";

            bool ok = true, isAlreadyDidTest = false;
            DateTime dateOfBirth = new DateTime(), lastTest = new DateTime(1990, 1, 1);
            string lastName, firstName, schoolName, teacherName;
            int id, phoneNumber, buildingNumber, numOfFinishedLessons, numOfTests;
            Address address = new Address();

            ok = int.TryParse(this.ID.Text, out id);
            if (!ok)
            {
                errorList += numOfErrors++;
                errorList += ". Cant convert Id input to int.\n";
                ok = true;
            }
            firstName = this.FirstName.Text;
            lastName = this.LastName.Text;

            ok = DateTime.TryParse(this.BirthDate.Text, out dateOfBirth);
            if (!ok)
            {
                errorList += numOfErrors++;
                errorList += ". Cant convert Birth-Date input to DateTime object.\n";
                ok = true;
            }

            ok = int.TryParse(this.PhoneNumber.Text, out phoneNumber);
            if (!ok)
            {
                errorList += numOfErrors++;
                errorList += ". Cant convert Phone number input to int.\n";
                ok = true;
            }

            ok = int.TryParse(this.BuildingNumber.Text, out buildingNumber);
            if (!ok)
            {
                errorList += numOfErrors++;
                errorList += ". Cant convert building number input to int.\n";
                ok = true;
            }
            else
                address = new Address(this.City.Text, this.Street.Text, buildingNumber);
            ok = int.TryParse(this.NumOfLessons.Text, out numOfFinishedLessons);
            if (!ok)
            {
                errorList += numOfErrors++;
                errorList += ". Cant convert number of lessons input to int.\n";
                ok = true;
            }

            ok = int.TryParse(this.NumOfTests.Text, out numOfTests);
            if (!ok)
            {
                errorList += numOfErrors++;
                errorList += ". Cant convert building number input to int.\n";
                ok = true;
            }

            if (this.isDidTest.IsChecked == true)
            {
                isAlreadyDidTest = true;
                ok = DateTime.TryParse(this.LastTestDate.Text, out lastTest);
                if (!ok)
                {
                    errorList += numOfErrors++;
                    errorList += ". Cant convert last-test-Date input to DateTime object.\n";
                    ok = true;
                }
            }
            if (this.Bus.IsChecked == true)
                trainee.ExistingLicenses.Add(CarTypeEnum.Bus);
            if (this.Private.IsChecked == true)
                trainee.ExistingLicenses.Add(CarTypeEnum.PrivateCar);
            if (this.MotorCycle.IsChecked == true)
                trainee.ExistingLicenses.Add(CarTypeEnum.MotorCycle);
            if (this.Truck12.IsChecked == true)
                trainee.ExistingLicenses.Add(CarTypeEnum.Truck12Tons);
            if (this.TruckUnlimited.IsChecked == true)
                trainee.ExistingLicenses.Add(CarTypeEnum.TruckUnlimited);
            if (errorList == "")
            {
                trainee.Id = int.Parse(ID.Text);
                trainee.LastName = LastName.Text;
                trainee.FirstName = FirstName.Text;
                trainee.DateOfBirth = DateTime.Parse(BirthDate.Text);
                trainee.PhoneNumber = int.Parse(PhoneNumber.Text);
                trainee.SchoolName = SchoolName.Text;
                trainee.TeacherName = TeacherName.Text;
                trainee.NumOfFinishedLessons = int.Parse(NumOfLessons.Text);
                trainee.Address = address;
                trainee.NumOfTests = int.Parse(NumOfTests.Text);
                trainee.IsAlreadyDidTest = isAlreadyDidTest;
                trainee.LastTest = DateTime.Parse(LastTestDate.Text);
                if (this.Gender.Text == "male")
                    trainee.Gender = GenderEnum.Male;
                if (this.Gender.Text == "female")
                    trainee.Gender = GenderEnum.Female;

            }
            BL bl = new BL();
            try
            {
                bl.AddTrainee(trainee);
            }
            catch (Exception t)
            {
                errorList += "\n" + t.Message;
            }
            if (errorList != "")
            {
                //errorList = " here's why:\n" + errorList;
                MessageBox.Show(errorList, "Can't add this Trainee!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
