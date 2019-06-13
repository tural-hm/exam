using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Imtahan
    {
        public int id { get; set; }
        [Required]
        [MaxLength(3)]
        public string Kod { get; set; }
        [Required]
        [Range(1, 99999, ErrorMessage = "Value must be between 1 to 99999")]
        public int studentCode { get; set; }

        public DateTime Date { get; set; }
        [Required]
        [Range(1, 9, ErrorMessage = "Value must be between 1 to 9")]
        public int Result { get; set; }
        public virtual Sagird Sagird { get; set; }
    }
}