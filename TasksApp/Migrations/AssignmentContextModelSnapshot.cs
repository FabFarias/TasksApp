﻿// <auto-generated />
using DashboardApp.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DashboardApp.Migrations
{
    [DbContext(typeof(AssignmentContext))]
    partial class AssignmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("System.Threading.Tasks.Task", b =>
                {
                    b.ToTable("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
