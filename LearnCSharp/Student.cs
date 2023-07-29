namespace LearnCSharp
{
    internal class Student
    {
        private int StudentId { get; set; }
        private string? Name { get; set; }
        private DateTime DateOfBirth { get; set; }
        private bool IsOnScholarship { get; set; }

        public Student(int studentId, string name, DateTime dateOfBirth, bool isOnScholarship)
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
