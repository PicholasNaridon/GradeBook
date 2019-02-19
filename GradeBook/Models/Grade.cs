using GradeBook.Services;

namespace GradeBook.Models
{
    public class Grade : EntityBase
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseAssignmentId { get; set; }
        public CourseAssignment CourseAssignment { get; set; }

        public int NumGrade { get; set; }
        public string LetterGrade { get; set; }
    }
}