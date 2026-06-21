namespace MVCPatternExample
{
    public class StudentController
    {
        private Student _student;
        private StudentView _studentView;

        public StudentController(Student student, StudentView studentView)
        {
            _student = student;
            _studentView = studentView;
        }

        public void UpdateStudentName(string name)
        {
            _student.Name = name;
        }

        public void UpdateStudentGrade(string grade)
        {
            _student.Grade = grade;
        }

        public void DisplayStudent()
        {
            _studentView.DisplayStudentDetails(_student);
        }

        public Student GetStudent()
        {
            return _student;
        }
    }
}
