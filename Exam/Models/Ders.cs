using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Exam.Models
{
    public class Ders
    {
        public int id { get; set; }
        [Required]
        [MaxLength(3)]
        public string Kod { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "Value must be between 1 to 99")]
        public int Number { get; set; }
        [Required]
        [MaxLength(20)]
        public string TeacherName { get; set; }
        [Required]
        [MaxLength(20)]
        public string TeacherSurname { get; set; }
    }
}