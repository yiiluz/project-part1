using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{  
    interface IDAL
    {
        void addTest(Ex1_BE.Test T);
        void removeTest(Ex1_BE.Test T);
        void updateTestDetails(Ex1_BE.Test T);
        void addStudent(Ex1_BE.Trainee T);
        void removeStudent(Ex1_BE.Trainee T);
        void updateStudentDetails(Ex1_BE.Trainee T);
        Ex1_BE.Tester getListOfAllExaminers();
        Ex1_BE.Trainee getListAllStudents();
        Ex1_BE.Test gatListAllTests();
    }
}
