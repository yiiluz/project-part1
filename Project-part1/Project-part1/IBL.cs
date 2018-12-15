using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_BE;

namespace Project_part1
{
    public interface IBL
    {
        void AddTester(Tester T);
        void RemoveTester(Tester T);
        void UpdateTesterDetails(Tester T);
        void AddTrainee(Trainee T);
        void RemoveTrainee(Trainee T);
        void UpdateTraineeDetails(Trainee T);
        void AddTest(Test t);
        void UpdateTest(Test t);
        List<Tester> GetTestersList();
        List<Trainee> GetTraineeList();
        List<Test> GetTestsList();
    }
}
