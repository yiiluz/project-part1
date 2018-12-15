using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{  
    interface Idal
    {
        void addTest(Object T);
        void removeTest(Object T);
        void updateTestDetails(Object T);
        void addStudent(Object T);
        void removeStudent(Object T);
        void updateStudentDetails(Object T);
        Object getListOfAllExaminers();
        Object getListAllStudents();
        Object gatListAllTests();
    }
}
