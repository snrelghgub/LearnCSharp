namespace LearnCSharp.Models
{
    internal class Student
    {
        private string StudentId { get; set; }
        public string? Name { get; set; }
        private DateTime DateOfBirth { get; set; }
        private bool IsOnScholarship { get; set; }

        public Student(string studentId, string name, DateTime dateOfBirth, bool isOnScholarship)
        {
            StudentId = studentId;
            Name = name;
            DateOfBirth = dateOfBirth;
            IsOnScholarship = isOnScholarship;
        }
        public bool HasScholarship()
        {
            return IsOnScholarship;
        }
    }
}
