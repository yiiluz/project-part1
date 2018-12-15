using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_BE
{
    class Trainee
    {
        int id;
        string lastName;
        string firstName;
        DateTime dateOfBirth;
        GenderEnum gender;
        int phoneNumber;
        Address address;
        CarTypeEnum typeOfCar;
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
        internal CarTypeEnum TypeOfCar
        {
            get => typeOfCar;
            set => typeOfCar = value;
        }
    }
}
