using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_DAL;
using Ex1_BE;

namespace Ex1_BL
{
    public class BL : IBL
    {
        IDAL instance = Dal_imp.GetInstance();
        public void AddTester(Tester t)
        {
            if (t.DateOfBirth.Year < ((DateTime.Now).Year - 40))
                throw new Exception("Can't add the tester " + t.FirstName + " " + t.LastName + ". tester age must be above 40.");
            else
            {
                try
                {
                    instance.AddTester(t);
                }
                catch (DuplicateWaitObjectException)
                {
                    //תעשה מה שבאלך
                    throw;
                }

            }
        }
        public void RemoveTester(Tester T)
        {
            try
            {
                instance.RemoveTester(T);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Cant delete Tester " + T.FirstName + " " + T.LastName + " because is not exist on the system.");
            }
        }
        public void RemoveTrainee(Trainee T)
        {
            try
            {
                instance.RemoveTrainee(T);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Cant delete Trainee " + T.FirstName + " " + T.LastName + " because is not exist on the system.");
            }
        }
        public void AddTrainee(Trainee t)
        {
            if (t.DateOfBirth.Year < ((DateTime.Now).Year - 18))
                throw new Exception("Can't add the trainee " + t.FirstName + " " + t.LastName + ". trainee age must be above 18.");
            else
            {
                try
                {
                    instance.AddTrainee(t);
                }
                catch (DuplicateWaitObjectException)
                {
                    //איציק תכתוב פה מה שבזין שלך
                    throw;
                }

            }
        }
        public void AddTest(Test t)
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
            tester.AvailableWorkTime[(int)t.DateOfTest.DayOfWeek, t.DateOfTest.Hour % 9] = false;
            try
            {
                instance.AddTest(t);
            }
            catch (DuplicateWaitObjectException)
            {
                //איציק תכתוב מה שבא לך
                throw;
            }

        }
        public void UpdateTesterDetails(Tester T)
        {
            var testerIndex = instance.GetTestersList().FindIndex(x => x.Id == T.Id);
            if (testerIndex < 0)
                throw new KeyNotFoundException("Tester does not exist on the list");
            else
            {
                instance.RemoveTester(instance.GetTestersList().ElementAt(testerIndex));
                instance.AddTester(T);
            }
        }
        public void UpdateTraineeDetails(Trainee T) //resume that PL can get Trainee object by id, update his deateils, and this func only swap old with new
        {
            var traineeIndex = instance.GetTraineeList().FindIndex(x => x.Id == T.Id);
            if (traineeIndex < 0)
                throw new KeyNotFoundException("Trainee does not exist on the list");
            else
            {
                instance.RemoveTrainee(instance.GetTraineeList().ElementAt(traineeIndex));
                instance.AddTrainee(T);
            }
        }
        public void UpdateTest(Test t)
        {
            var testIndex = instance.GetTestsList().FindIndex(x => x.TestId == t.TestId);
            if (testIndex < 0)
                throw new KeyNotFoundException("Test does not exist on the list, cant update");
            else
            {
                instance.RemoveTest(instance.GetTestsList().ElementAt(testIndex));
                instance.AddTest(t);
            }
        }
        public void RemoveTest(Test t)
        {
            instance.RemoveTest(t);
        }
        public int GetIntOfTestID(Test t) //return -1 if there is problem with the test id string
        {
            int tmp;
            bool ok = int.TryParse(t.TestId, out tmp);
            if (ok)
                return tmp;
            else
                return -1;
        }
        public Test GetTestByID(int id)
        {
            var test = instance.GetTestsList().Find(x => GetIntOfTestID(x) == id);
            if (test == null)
                throw new KeyNotFoundException("This test id does not exist on the list");
            else
                return test;
        }
        public Tester GetTesterByID(int id)
        {
            var tester = instance.GetTestersList().Find(x => x.Id == id);
            if (tester == null)
                throw new KeyNotFoundException("This tester id does not exist on the list");
            else
                return tester;

        }
        public Trainee GetTraineeByID(int id)
        {
            var trainee = instance.GetTraineeList().Find(x => x.Id == id);
            if (trainee == null)
                throw new KeyNotFoundException("This trainee id does not exist on the list");
            else
                return trainee;
        }
        public List<Tester> GetTestersList()
        {
            return instance.GetTestersList();
        }
        public List<Trainee> GetTraineeList()
        {
            return instance.GetTraineeList();
        }
        public List<Test> GetTestsList()
        {
            return instance.GetTestsList();
        }
        public IEnumerable<Tester> AvailableTeacher(DateTime time)
        {
            var AvailableTesters = from item in instance.GetTestersList()
                                   orderby item.LastName,item.FirstName
                                   where item.AvailableWorkTime[(int)time.DayOfWeek, time.Hour] == true
                                  select item;
            return AvailableTesters;
        }
        public int NumberOfTestsTested(Trainee t)
        {
            return t.NumOfTests;
        }
        public bool IsEntitledToALicenseOrNot(Trainee T, CarTypeEnum car)
        {

            return T.ExistingLicenses.Exists(x => x == car);
        }
        public IEnumerable<Test> TheTestsWillBeDoneToday_Month(DateTime t, bool Byday)
        {
            if (Byday == true)
            {
                var toDay = from item in instance.GetTestsList()
                            orderby item.TestId
                            where item.DateOfTest.DayOfYear == t.DayOfYear
                            select item;
                return toDay;
            }
            var ThisMonth = from item in instance.GetTestsList()
                            orderby item.TestId
                            where item.DateOfTest.Month == t.Month
                            select item;
            return ThisMonth;
        }
        public IEnumerable<Test> GetTestsPartialListByPredicate(Func<Test, bool> func)
        {
            var StandOnTheCondition = from item in instance.GetTestsList()
                                      orderby item.TestId
                                      where func(item) == true
                                      select item;
            return StandOnTheCondition;
        }
        public IEnumerable<IGrouping<CarTypeEnum, Tester>> GetTestersBySpecialization(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var TestersGroupsWithOrder = from item in instance.GetTestersList()
                                             orderby item.LastName,item.FirstName
                                             group item by item.TypeOfCar 
                                             into g orderby g.Key select g;
                return TestersGroupsWithOrder;
            }
            var TestersGroupsWithoutOrder = from item in instance.GetTestersList()
                                            group item by item.TypeOfCar;
            return TestersGroupsWithoutOrder;
        }
        public IEnumerable<IGrouping<string, Trainee>> GetStudentGroupsBySchool(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var StudentGroupsByAttributeWithOrder = from item in instance.GetTraineeList()
                                                        orderby item.LastName,item.FirstName
                                                        group item by item.SchoolName 
                                                        into g orderby g.Key select g;
                return StudentGroupsByAttributeWithOrder;
            }
            var StudentGroupsByAttributeWithOutOrder = from item in instance.GetTraineeList()
                                                       group item by item.SchoolName;

            return StudentGroupsByAttributeWithOutOrder;
        }
        public IEnumerable<IGrouping<string, Trainee>> GetStudentGroupsByTeacher(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var StudentGroupsByTeacherWithOrder = from item in instance.GetTraineeList()
                                                      orderby item.LastName,item.FirstName
                                                      group item by item.SchoolName 
                                                      into  g orderby g.Key select g;           
                return StudentGroupsByTeacherWithOrder;
            }
            var StudentGroupsByTeacherWithOutOrder = from item in instance.GetTraineeList()
                                                     group item by item.SchoolName;
            return StudentGroupsByTeacherWithOutOrder;
        }
        public IEnumerable<IGrouping<int, Trainee>>GetStudentsGroupedaccordingByNumOfTests(bool byOrder = false)
        {
            if (byOrder == true)
            {
                var StudentsGroupedaccordingByNumOfTestsWithOrder = from item in instance.GetTraineeList()
                                                                    orderby item.LastName,item.FirstName
                                                                    group item by item.NumOfTests 
                                                                    into g orderby g.Key select g;
                return StudentsGroupedaccordingByNumOfTestsWithOrder;
            }
            var StudentsGroupedaccordingByNumOfTestsWithOutrder = from item in instance.GetTraineeList()
                                                                  group item by item.NumOfTests;
            return StudentsGroupedaccordingByNumOfTestsWithOutrder;

        }
    }
}