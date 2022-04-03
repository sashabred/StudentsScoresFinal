using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentsScoresFinal.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 5, ErrorMessage = "Оценка не может быть меньше 0 и больше 5")]
        [DisplayName("Оценка")]
        public int ScoreNum { get; set; }


        [DisplayName("Дата оценки")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        
        public int SubjectId { get; set; }


        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }
                     
        public int StudentId { get; set; }


        [ForeignKey("StudentId")]
        public Student Student { get; set; }


    }
}