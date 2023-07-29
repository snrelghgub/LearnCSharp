namespace LearnCSharp
{
    internal class Student
    {
        private string StudentId { get; set; }
        public string? Name { get; set; }
        private DateTime DateOfBirth { get; set; }
        private bool IsOnScholarship { get; set; }

        public Student(string studentId, string name, DateTime dateOfBirth, bool isOnScholarship)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.IsOnScholarship = isOnScholarship;
        }
        public bool HasScholarship()
        {
            return this.IsOnScholarship;
        }
    }
}
