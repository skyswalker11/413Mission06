using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413Mission06.Models
{
    public class EnterTaskSubmission
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        [Required(ErrorMessage = "Task is Required")]
        public string Task { get; set; }
        public string DueDate { get; set; }
        [Required(ErrorMessage = "Quadrant is Required")]
        public string Quadrant { get; set; }
        public string Category { get; set; }
        public bool Completed { get; set; }
        public int CategoryID { get; internal set; }
    }
}

