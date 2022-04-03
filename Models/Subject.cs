using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsScoresFinal.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Предмет")]
        [MaxLength(100)]
        public string Title { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}