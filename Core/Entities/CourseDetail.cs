using System;
using System.Collections.Generic;

namespace Data.Entities;

public partial class CourseDetail
{
    public int CourseId { get; set; }

    public string? Description { get; set; }

    public string? SyllabusUrl { get; set; }

    public int? MaxCapacity { get; set; }

    public virtual Course Course { get; set; } = null!;
}
