﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public partial class GetExamQuestionsByIdResult
    {
        public int ExamID { get; set; }
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
    }
}
