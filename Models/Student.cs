using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsScoresFinal.Models
{
    public class Student
    {

        [Key]
        public int Id { get; set; }


        [DisplayName("Имя")]
        [MaxLength(80)]
        public string Name { get; set; }


        [DisplayName("Фамилия")]
        [MaxLength(100)]
        public string FamilyName { get; set; }


        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Группа")]
        [MaxLength(10)]
        public string Group { get; set; }
        

        public string toString()
        {
            return Name + " " + FamilyName;
        }
        public string Fio
        {
            get
            {
                return Name + " " + FamilyName;
            }
        }
        public virtual ICollection<Score> Scores { get; set; }
    }
}