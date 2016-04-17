namespace ContosoUniversityTutorial.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //By giving the enrollment class ID's of the other classes you are creating a one to many relationship - the other classes do not have enrollment ID's
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //navigation properties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
