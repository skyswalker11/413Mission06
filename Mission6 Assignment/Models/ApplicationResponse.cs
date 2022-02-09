using System;
using System.ComponentModel.DataAnnotations;

namespace mission6.Models
{
    public class ApplicationResponse
    {

        [Key]

        [Required]

        public int ApplicationId { get; set; }



        [Required]
        public string Task { get; set; }

 


}
}
