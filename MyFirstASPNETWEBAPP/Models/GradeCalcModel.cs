using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Model for Grade Calculator
namespace MyFirstASPNETWEBAPP.Models
{
    public class GradeCalcModel
    {
        // Data Validation for Inputs in Calculator
        [Required]
        [Range(0,100, ErrorMessage = "Please Enter a Number Between 0 and 100")]
        public int atext { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Please Enter a Number Between 0 and 100")]
        public int gtext { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Please Enter a Number Between 0 and 100")]
        public int qtext { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Please Enter a Number Between 0 and 100")]
        public int mtext { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Please Enter a Number Between 0 and 100")]
        public int ftext { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Please Enter a Number Between 0 and 100")]
        public int itext { get; set; }
    }
}
