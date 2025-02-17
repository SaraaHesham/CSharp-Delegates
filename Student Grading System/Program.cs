


namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Welcome To My Grading System");
            
                Console.Write("Enter Your Name: ");
                string studentName = Console.ReadLine();

                List<int> studentGrades = new List<int>();

                Console.Write("Enter The Number Of your Grades : ");
                int numberOfGrades = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfGrades; i++)
                {
                    Console.Write($"Enter Your Grade For The Subject Number {i+1}: ");
                    int grade = int.Parse(Console.ReadLine());
                    studentGrades.Add(grade);
                }

                Student student = new Student();
                student.Name = studentName;
                student.Grades = studentGrades;
                students.Add(student);

                Console.WriteLine("Student Added Successfully");

                Console.WriteLine("Do You Want To Add Another Student? (Y/N)");
                string answer = Console.ReadLine();
                
                if (answer.ToLower() == "n")
                {
                    break;
                }

            }

            GradingSystem gradingSystem = new GradingSystem();
            gradingSystem.DisplayGradingInfo(students, CalculateAverage01,checkIfPassed01,displayStudentData01);

        }

        private static void displayStudentData01(Student student, double averageGrade, bool isPassed)
        {
            Console.WriteLine($"Student Name: {student.Name} , Average Grade: {averageGrade}");
            if (isPassed)
            {
                Console.WriteLine("Student Passed");
            }
            else
            {
                Console.WriteLine("Student Failed");
            }
        }

        private static bool checkIfPassed01(double avgValue)
        {
            if (avgValue >= 50)
            {
                return true;
            }
            return false;
        }

        private static double CalculateAverage01(List<int> grades)
        {
            return grades.Sum() / grades.Count;
        }
    }
}
