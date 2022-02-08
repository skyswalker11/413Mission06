

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int Applicationid { get; set; }
        [Required(ErrorMessage = "Task is Required")]
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        [Required(ErrorMessage = "Quadrant is Required")]
        public string Quadrant { get; set; }
        public string Category { get; set; }
        public bool Completed { get; set; }


    }
}

