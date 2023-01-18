using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstProject1.Models
{
    public class EmpModle
    {
        public int eNo { get; set; }
        [Required(ErrorMessage = "Enter Your Name")]
        public string eName { get; set; }
        [Required]
        public double? eSal { get; set; }
        [Required]
        public string eDep { get; set; }
        [Required]
        public double? eAge { get; set; }
        [Required]
        public int? eAdhar { get; set; }
    }
}