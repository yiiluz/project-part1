using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex1_BE;
using DS;
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

        void IDAL.AddTest(Test t)
        {
            DataSource dataSource 
        }

        void IDAL.AddTester(Tester T)
        {
            throw new NotImplementedException();
        }

        void IDAL.AddTrainee(Trainee T)
        {
            throw new NotImplementedException();
        }

        List<Tester> IDAL.GetTestersList()
        {
            throw new NotImplementedException();
        }

        List<Test> IDAL.GetTestsList()
        {
            throw new NotImplementedException();
        }

        List<Trainee> IDAL.GetTraineeList()
        {
            throw new NotImplementedException();
        }

        void IDAL.RemoveTester(Tester T)
        {
            throw new NotImplementedException();
        }

        void IDAL.RemoveTrainee(Trainee T)
        {
            throw new NotImplementedException();
        }

        void IDAL.UpdateTest(Test t)
        {
            throw new NotImplementedException();
        }

        void IDAL.UpdateTesterDetails(Tester T)
        {
            throw new NotImplementedException();
        }

        void IDAL.UpdateTraineeDetails(Trainee T)
        {
            throw new NotImplementedException();
        }
    }
}
