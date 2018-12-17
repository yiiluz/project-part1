using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_DAL;
using Ex1_BE;

namespace Project_part1
{
    class BL //: IBL
    {
        IDAL instance;// = Dal_imp.GetInstance();
        void AddTester(Tester t)
        {
            if (t.DateOfBirth.Year < ((DateTime.Now).Year - 40))
                throw new Exception("Can't add the tester " + t.FirstName + " " + t.LastName + ". tester age must be above 40.");
            else
                instance.AddTester(t);
        }
        void AddTrainee(Trainee t)
        {
            if (t.DateOfBirth.Year < ((DateTime.Now).Year - 18))
                throw new Exception("Can't add the trainee " + t.FirstName + " " + t.LastName + ". trainee age must be above 18.");
            else
                instance.AddTrainee(t);
        }
        void AddTest(Test t)
        {
            var trainee = instance.GetTraineeList().Find(x => x.Id == t.TraineeId);
            var tester = instance.GetTestersList().Find(x => x.Id == t.TesterId);
            if (tester == null)
                throw new Exception("tester doesnt exist");
            if (trainee == null)
                throw new Exception("trainee doesnt exist");
            if ((trainee.IsAlreadyDidTest) && ((t.DateOfTest.Day - trainee.LastTest.Day) < 7))
                throw new Exception("Can't add the test " + t.TestId + ". must pass anlist 7 days from trainee last test.");
            else if (trainee.NumOfFinishedLessons < 20)
                throw new Exception("Can't add the test " + t.TestId + ". the trainee " + trainee.FirstName + " " + trainee.LastName
                    + " is not done enough lessons");
            else if (!(tester.AvailableWorkTime[t.DateOfTest.Day, t.DateOfTest.Hour]))
                throw new Exception("The tester is unavailable in the test date.");
            else if ((trainee.ExistingLicenses).Exists(x => x == t.CarType))
                throw new Exception("The trainee " + trainee.FirstName + " " + trainee.LastName + " already passed test of " + t.CarType + ".");
            else if (tester.NumOfTestOfCurrWeek == tester.MaxTestsPerWeek)
                throw new Exception("Tester already done " + tester.MaxTestsPerWeek + " tests this week.");
            if (t.DateOfTest < DateTime.Now)
            {
                tester.NumOfTestOfCurrWeek++;
                trainee.IsAlreadyDidTest = true;
                trainee.LastTest = t.DateOfTest;
            }
            if (t.IsPassed)
                trainee.ExistingLicenses.Add(t.CarType);
            tester.NumOfTestOfCurrWeek++;
            instance.AddTest(t);
        }

    }
}
