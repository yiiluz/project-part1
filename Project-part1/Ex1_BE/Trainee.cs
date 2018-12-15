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
        DateTime dateOfBirth;
        GenderEnum gender;
        int phoneNumber;
        Address address;
        CarTypeEnum typeOfCar;
        GearboxTypeEnum typeOfGearbox;
        string schoolName;
        string teacherName;
        int numOfFinishedLessons;

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
            set
            {
                DateTime now = DateTime.Now;
                now.AddYears(-18);
                if (value < now)
                    throw new Exception("Can't add Trainee under age 18");
                else
                    dateOfBirth = value;
            }
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
        internal CarTypeEnum TypeOfCar
        {
            get => typeOfCar;
            set => typeOfCar = value;
        }
        internal GearboxTypeEnum TypeOfGearbox
        {
            get => typeOfGearbox;
            set => typeOfGearbox = value;
        }
        internal Address Address
        {
            get => address;
            set => address = value;
        }
        internal GenderEnum Gender
        {
            get => gender;
            set => gender = value;
        }
        public string ToString()
        {
            string tmp = "Tester name: " + FirstName + " " + LastName + ".\nID: " + Id + ".\nGender: " + Gender + ".\nDate Of Birth: " + DateOfBirth +
                ".\nPhone number: " + PhoneNumber + ".\nAddress: " + Address + ".\nType of car: " + TypeOfCar +
                ".\nType of Gearbox: " + TypeOfGearbox + ".\nSchool name: " + SchoolName +
                ".\nTeacher name: " + TeacherName + ".\nSum of pased lessons: " + numOfFinishedLessons + ".\n";
            return tmp;
        }
    }
}
