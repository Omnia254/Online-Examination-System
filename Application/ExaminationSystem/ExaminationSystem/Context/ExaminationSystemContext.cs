﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using ExaminationSystem.StoredProcedure;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Context;

public partial class ExaminationSystemContext : DbContext
{
    public ExaminationSystemContext()
    {
    }

    public ExaminationSystemContext(DbContextOptions<ExaminationSystemContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}