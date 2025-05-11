namespace Student_Grade_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1100, "Ali");
            Student s2 = new Student(2002, "Muna");

            s1.AddGrade(90);
            s1.AddGrade(85);

            s2.AddGrade(75);
            s2.AddGrade(80);

            s1.PrintStudentReport();
            s2.PrintStudentReport();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int[] grades;
        private int gradeCount;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            grades = new int[100]; // Fixed size
            gradeCount = 0;
        }

        public void AddGrade(int grade)
        {
            if (gradeCount < grades.Length)
            {
                grades[gradeCount] = grade;
                gradeCount++;
            }
            else
            {
                Console.WriteLine("Grade limit reached!");
            }
        }

        public double CalculateAverage()
        {
            if (gradeCount == 0) return 0;

            int total = 0;
            for (int i = 0; i < gradeCount; i++)
            {
                total += grades[i];
            }

            return (double)total / gradeCount;
        }

        public void PrintStudentReport()
        {
            Console.WriteLine($"\nStudent Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.Write("Grades: ");
            for (int i = 0; i < gradeCount; i++)
            {
                Console.Write(grades[i] + " ");
            }
            Console.WriteLine($"\nAverage: {CalculateAverage()}");
        }
    }
}
