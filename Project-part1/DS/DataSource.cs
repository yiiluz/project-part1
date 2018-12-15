using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DS
{
    public class DataSource
    {
        protected static DataSource dataSource = null;
        private static List<Ex1_BE.Test> tests;
        private static List<Ex1_BE.Tester> testers;
        private static List<Ex1_BE.Trainee> trainees;
        public Ex1_BE.Test GatListAllTests()
        {
            if (dataSource==null)
            {
                dataSource = new DataSource();
                return tests;
            }
            return tests;
        }
    }
}
