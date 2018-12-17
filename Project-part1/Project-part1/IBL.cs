using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_BE;

namespace Ex1_BL
{
    public interface IBL
    {
        void AddTester(Tester T);
        void RemoveTester(Tester T);
        void UpdateTesterDetails(Tester T);
        void AddTrainee(Trainee T);
        void RemoveTrainee(Trainee T);
        void RemoveTest(Test t);
        void UpdateTraineeDetails(Trainee T);
        void AddTest(Test t);
        void UpdateTest(Test t);
        Test GetTestByID(int id);
        Tester GetTesterByID(int id);
        Trainee GetTraineeByID(int id);
        int GetIntOfTestID(Test t);
        List<Tester> GetTestersList();
        List<Trainee> GetTraineeList();
        List<Test> GetTestsList();
    }
}
