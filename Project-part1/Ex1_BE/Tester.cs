using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_BE
{
    /// <summary>
    /// this class represent a tester object
    /// </summary>
  public  class Tester
    {
        int id;
        string lastName;
        string firstName;
        DateTime dateOfBirth;
        GenderEnum gender;
        int phoneNumber;
        Address address;
        double seniority;
        int maxTestsPerWeek;
        CarTypeEnum typeOfCar;
        bool[,] workTime = new bool[5, 6];
        double maxDistance;

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
        public DateTime DateOfBirth {
            get => dateOfBirth;
            set
            {
                DateTime now = DateTime.Now;
                now.AddYears(-18);
                if (value < now)
                    throw new Exception("Can't add Tester under age 18");
                else
                    dateOfBirth = value;
            }
        }
        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public double Seniority
        {
            get => seniority;
            set => seniority = value;
        }
        public int MaxTestsPerWeek
        {
            get => maxTestsPerWeek;
            set => maxTestsPerWeek = value;
        }
        public bool[,] WorkTime
        {
            get => workTime;
            set => workTime = value;
        }
        public double MaxDistance
        {
            get => maxDistance;
            set => maxDistance = value;
        }
        internal GenderEnum Gender
        {
            get => gender;
            set => gender = value;
        }
        internal Address Address
        {
            get => address;
            set => address = value;
        }
        internal CarTypeEnum TypeOfCar
        {
            get => typeOfCar;
            set => typeOfCar = value;
        }

        public string ToString()
        {
            string tmp = "Tester name: " + FirstName + " " + LastName + ".\nID: " + Id + ".\nGender: " + Gender + ".\nDate Of Birth: " + DateOfBirth +
                ".\nPhone number: " + PhoneNumber + ".\nAddress: " + Address + ".\nSeniority: " + Seniority + ".\nType of car: " + TypeOfCar +
                ".\nMax tests per week: " + MaxTestsPerWeek + ".\nMax distance for test: " + MaxDistance + ".\n";
            return tmp;
        }
    }
}
