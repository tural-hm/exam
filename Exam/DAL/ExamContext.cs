using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Exam.DAL
{
    public class ExamContext:DbContext
    {
        public ExamContext() : base("ExamContext")
        {
        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Imtahan> Imtahanlar { get; set; }
        public DbSet<Sagird> Sagirdler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}