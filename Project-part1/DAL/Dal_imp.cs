using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_BE;
using Ex1_DS;
namespace Ex1_DAL
{
    class Dal_imp : IDAL
    {     
        protected Dal_imp() { }
        protected static Dal_imp instance = null;
        public static Dal_imp GetInstance()
        {
            if (instance==null)
            {
                instance = new Dal_imp();            
            }
            return instance;
        }

        void  IDAL.AddTest(Test t)
        {
            if (t.)
            {

            }
        }

        void IDAL.AddTester(Tester t)
        {
            DataSource.testers.Add(t);
        }

        void IDAL.AddTrainee(Trainee t)
        {
            DataSource.trainees.Add(t);
        }

        List<Tester> IDAL.GetTestersList()
        {
            List<Tester> testers2 = DataSource.testers;
            return testers2;

        }

        List<Test> IDAL.GetTestsList()
        {
            List<Test> tests2 = DataSource.tests;
            return tests2;
        }

        List<Trainee> IDAL.GetTraineeList()
        {
            List<Trainee> trainees2 = DataSource.trainees;
            return trainees2;
        }

        void IDAL.RemoveTester(Tester T)
        {
            if (DataSource.testers.Find(x => x.Id == T.Id) != null)
            {
               DataSource.testers.Remove(DataSource.testers.Find(x => x.Id == T.Id));
            }
        }

        void IDAL.RemoveTrainee(Trainee T)
        {
            if (DataSource.trainees.Find(x => x.Id == T.Id) != null)
            {
                DataSource.trainees.Remove(DataSource.trainees.Find(x => x.Id == T.Id));
            }
        }

        void IDAL.UpdateTest(Test t)
        {
            int index = DataSource.tests.FindIndex(x => x.TestId == t.TestId);
            if(index >-1)
            {
                DataSource.tests[index] = t;
            }
        }

        void IDAL.UpdateTesterDetails(Tester T)
        {
            int index = DataSource.testers.FindIndex(x => x.Id == T.Id);
            if (index > -1)
            {
                DataSource.testers[index] =T;
            }
        }

        void IDAL.UpdateTraineeDetails(Trainee T)
        {
            int index = DataSource.trainees.FindIndex(x => x.Id == T.Id);
            if (index > -1)
            {
                DataSource.trainees[index] = T;
            }
        }
    }
}
