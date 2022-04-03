using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace StudentsScoresFinal.Models
{
    public class BaseDbInitialization : DropCreateDatabaseIfModelChanges<BaseDbContext>
    {
      
        protected override void Seed(BaseDbContext context)
        {
            context.Students.AddOrUpdate (x => x.Id,
                new Student {Id = 0,
                            Name = "Александр",
                            FamilyName = "Семенов",
                            DateOfBirth = new DateTime(2000, 01, 01),
                            Group = "A-21"
                },
               new Student{ Id = 1,
                            Name = "Анна",
                            FamilyName = "Иванова",
                            DateOfBirth = new DateTime(1999, 03, 21),
                            Group = "A-21"
                },
                new Student{Id = 2,
                            Name = "Ольга",
                            FamilyName = "Ковчук",
                            DateOfBirth = new DateTime(2002, 11, 01),
                            Group = "A-21"
                }
            );
            context.SaveChanges();


            context.Subjects.AddOrUpdate( x => x.Id,
            
                new Subject {Id=0, Title = "Информатика"},
                new Subject { Id =1, Title = "Высшая математика"},
                new Subject {  Id = 2, Title = "Философия"}
            );

            context.SaveChanges();
           
            base.Seed(context);
        }

    }
  }
