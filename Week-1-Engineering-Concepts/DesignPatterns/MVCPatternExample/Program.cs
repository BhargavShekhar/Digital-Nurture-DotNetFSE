using System;

namespace MVCPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object (Model)
            Student student = new Student(1, "John Doe", "A");

            // Create a StudentView (View)
            StudentView studentView = new StudentView();

            // Create a StudentController (Controller)
            StudentController studentController = new StudentController(student, studentView);

            // Display student details
            studentController.DisplayStudent();

            Console.WriteLine();

            // Update student details
            Console.WriteLine("After Update:\n");
            studentController.UpdateStudentName("Jane Doe");
            studentController.UpdateStudentGrade("A+");

            // Display updated information
            studentController.DisplayStudent();
        }
    }
}
