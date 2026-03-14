using System;
using System.Collections.Generic;

namespace DTOMiniPro.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public int? HostelId { get; set; }

    public virtual Hostel? Hostel { get; set; }
}
