﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Models;

[Table("Exam")]
public partial class Exam
{
    [Key]
    [Column("ExamID")]
    public int ExamId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExamDate { get; set; }

    [Column("InstructorID")]
    public int InstructorId { get; set; }

    [Column("CourseID")]
    public int CourseId { get; set; }

    [InverseProperty("Exam")]
    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    [ForeignKey("CourseId")]
    [InverseProperty("Exams")]
    public virtual Course Course { get; set; }

    [InverseProperty("Exam")]
    public virtual Grade Grade { get; set; }

    [ForeignKey("InstructorId")]
    [InverseProperty("Exams")]
    public virtual Instructor Instructor { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("Exams")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}