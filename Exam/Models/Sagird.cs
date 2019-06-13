using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Exam.Models
{
    public class Sagird
    {
        public int id { get; set; }
        [Required]
        [Range(1, 99999, ErrorMessage = "Value must be between 1 to 99999")]
        public int Nomre { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Range(1, 11, ErrorMessage = "Value must be between 1 to 11")]
        public int Class { get; set; }
       
        
    }
}