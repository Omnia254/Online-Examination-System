﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public DateTime ExamDate { get; set; }

    public int InstructorId { get; set; }

    public int CourseId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Course Course { get; set; }

    public virtual Grade Grade { get; set; }

    public virtual Instructor Instructor { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}