using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class GradingSystem
    {
        public void DisplayGradingInfo(List<Student> students,
            Func<List<int>,double> CalculateAverage,
            Predicate<double> checkIfPassed,
            Action<Student,double,bool> displayStudentData) 
        {
            foreach (var student in students)
            {
                double averageGrades = CalculateAverage(student.Grades);
                bool isStudentPassed = checkIfPassed(averageGrades);
                displayStudentData(student, averageGrades, isStudentPassed);
            }
        }
    }
}
