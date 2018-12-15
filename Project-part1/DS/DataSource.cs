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
        public static List<Ex1_BE.Test> tests;
        public static List<Ex1_BE.Tester> testers;
        public static List<Ex1_BE.Trainee> trainees;
        public static DataSource getDataSource()
        {
            if (dataSource==null)
            {
                dataSource = new DataSource();
                return dataSource;
            }
            return dataSource;
        }
    }
}
