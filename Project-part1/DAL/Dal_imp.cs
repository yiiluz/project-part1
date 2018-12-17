using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_BE;
using Ex1_DS;
namespace Ex1_DAL
{
    public class Dal_imp : IDAL
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
            if (t.IsHaveId==false)
            {
                t.TestId = string.Format("00000000", Configuration.TestId++);
                DataSource.tests.Add(t);
            }
            else
            {
                throw  new DuplicateWaitObjectException("The test already exists in the system ");
            }
        }

        
        void IDAL.AddTester(Tester t)
        {
            if (DataSource.testers.Find(x => x.Id == t.Id) != null)
            {
                throw new DuplicateWaitObjectException("This tester is already registered in the system");
            }
            else
            {
                DataSource.testers.Add(t);
            }
        }

        void IDAL.AddTrainee(Trainee t)
        {
            if (DataSource.trainees.Find(x=> x.Id == t.Id) != null)
            {
                throw new DuplicateWaitObjectException("This trainee is already registered in the system");
            }
            else
            {
                DataSource.trainees.Add(t);
            }
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
            else
            {
                throw new KeyNotFoundException("This tester does not exist in the system");
            }
        }

        void IDAL.RemoveTrainee(Trainee T)
        {
            if (DataSource.trainees.Find(x => x.Id == T.Id) != null)
            {
                DataSource.trainees.Remove(DataSource.trainees.Find(x => x.Id == T.Id));
            }
            else
            {
                throw new KeyNotFoundException("This trainee does not exist in the system");
            }
        }

        void IDAL.UpdateTest(Test t)
        {
            int index = DataSource.tests.FindIndex(x => x.TestId == t.TestId);
            if(index >-1)
            {
                DataSource.tests[index] = t;
            }
            else
            {
                throw new KeyNotFoundException("This test does not exist in the system");
            }
        }

        void IDAL.UpdateTesterDetails(Tester T)
        {
            int index = DataSource.testers.FindIndex(x => x.Id == T.Id);
            if (index > -1)
            {
                DataSource.testers[index] =T;
            }
            else
            {
                throw new Exception("This tester does not exist in the system");
            }
        }

        void IDAL.UpdateTraineeDetails(Trainee T)
        {
            int index = DataSource.trainees.FindIndex(x => x.Id == T.Id);
            if (index > -1)
            {
                DataSource.trainees[index] = T;
            }
            else
            {
                throw new KeyNotFoundException("this trainee does not exist in the system");
            }
        }
    }
}
