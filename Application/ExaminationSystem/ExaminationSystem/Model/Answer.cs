﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Model;

public partial class Answer
{
    public int ExamId { get; set; }

    public int? StudentId { get; set; }

    public int QuestionId { get; set; }

    public int? Answer1 { get; set; }

    public virtual Choice Answer1Navigation { get; set; }

    public virtual Exam Exam { get; set; }

    public virtual Question Question { get; set; }

    public virtual Student Student { get; set; }
}