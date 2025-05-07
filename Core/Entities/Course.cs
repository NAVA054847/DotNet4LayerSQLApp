using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int Credits { get; set; }

    public int? InstructorId { get; set; }

    public virtual CourseDetail? CourseDetail { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
