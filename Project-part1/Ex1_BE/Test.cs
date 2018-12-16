using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_BE
{
    public class Test
    {
        string testId;
        int testerId;
        int traineeId;
        DateTime dateOfTest;
        Address startTestAddress;
        CarTypeEnum carType;
        bool distanceKeeping;
        bool reverseParking;
        bool mirrorsCheck;
        bool signals;
        bool correctSpeed;
        bool isPassed;
        bool isHaveId;


        public string TestId
        {
            get => testId;
            set => testId = value;
        }
        public int TesterId
        {
            get => testerId;
            set => testerId = value;
        }
        public int TraineeId
        {
            get => traineeId;
            set => traineeId = value;
        }
        public DateTime DateOfTest
        {
            get => dateOfTest;
            set => dateOfTest = value;
        }
        public bool DistanceKeeping
        {
            get => distanceKeeping;
            set => distanceKeeping = value;
        }
        public bool ReverseParking
        {
            get => reverseParking;
            set => reverseParking = value;
        }
        public bool MirrorsCheck
        {
            get => mirrorsCheck;
            set => mirrorsCheck = value;
        }
        public bool Signals
        {
            get => signals;
            set => signals = value;
        }
        public bool CorrectSpeed
        {
            get => correctSpeed;
            set => correctSpeed = value;
        }
        public bool IsPassed
        {
            get => isPassed;
            set => isPassed = value;
        }

        public bool IsHaveId
        {
            get => isHaveId;
            set => isHaveId = value;
        }
        public CarTypeEnum CarType { get => carType; set => carType = value; }
        internal Address StartTestAddress
        {
            get => startTestAddress;
            set => startTestAddress = value;
        }

        override public string ToString()
        {
            string tmp = "Test ID: " + TestId + ".\nTester ID: " + TesterId + ".\nTrainee ID: " + TraineeId + ".\nDate of Test: " +
                DateOfTest + ".\nTest-start address: " + StartTestAddress + ".\n" + (IsPassed ? "Trainee pass" : "Trainee didn't pass") + ".\n";
            return tmp;
        }
    }
}
