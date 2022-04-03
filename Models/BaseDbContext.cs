using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentsScoresFinal.Models
{
    public class BaseDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }

        public DbSet<Score> Scores { get; set; }

        public DbSet<Subject> Subjects { get; set; }

       
    }
}