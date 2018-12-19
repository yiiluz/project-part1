using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_BE
{
    public class Trainee
    {

        int id;
        string lastName;
        string firstName;
        DateTime dateOfBirth = new DateTime();
        GenderEnum gender;
        int phoneNumber;
        Address address = new Address();
        //CarTypeEnum typeOfCar;
        GearboxTypeEnum typeOfGearbox;
        string schoolName;
        string teacherName;
        int numOfFinishedLessons;
        int numOfTests;
        bool isAlreadyDidTest;
        DateTime lastTest = new DateTime();
        public List<CarTypeEnum> existingLicenses = new List<CarTypeEnum>();

        public Trainee() { }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        /// <summary>
        /// this property can throw an Exaption
        /// </summary>
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }
        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public string SchoolName
        {
            get => schoolName;
            set => schoolName = value;
        }
        public string TeacherName
        {
            get => teacherName;
            set => teacherName = value;
        }
        public int NumOfFinishedLessons
        {
            get => numOfFinishedLessons;
            set => numOfFinishedLessons = value;
        }
        //internal CarTypeEnum TypeOfCar
        //{
        //    get => typeOfCar;
        //    set => typeOfCar = value;
        //}
        public GearboxTypeEnum TypeOfGearbox
        {
            get => typeOfGearbox;
            set => typeOfGearbox = value;
        }
        public Address Address
        {
            get => address;
            set => address = value;
        }
        public GenderEnum Gender
        {
            get => gender;
            set => gender = value;
        }
        public int NumOfTests
        {
            get => numOfTests;
            set => numOfTests = value;
        }
        public bool IsAlreadyDidTest
        {
            get => isAlreadyDidTest;
            set => isAlreadyDidTest = value;
        }
        public DateTime LastTest { get => lastTest; set => lastTest = value; }
        public List<CarTypeEnum> ExistingLicenses { get => existingLicenses; set => existingLicenses = value; }

        override public string ToString()
        {
            string existLin = "";
            foreach (var item in ExistingLicenses)
                existLin += (item.ToString() + " ");
            string tmp = "Trainee name: " + FirstName + " " + LastName + ".\nID: " + Id + ".\nGender: " + Gender + ".\nDate Of Birth: " + DateOfBirth.Date +
                ".\nPhone number: " + PhoneNumber + ".\nAddress: " + Address.ToString() + ".\nExisting linsences: " + existLin +
                ".\nType of Gearbox: " + TypeOfGearbox + ".\nSchool name: " + SchoolName +
                ".\nTeacher name: " + TeacherName + ".\nSum of pased lessons: " + numOfFinishedLessons + ".\n";
            return tmp;
        }
    }
}
