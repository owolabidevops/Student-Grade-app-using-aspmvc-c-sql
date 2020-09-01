using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Studentgrade.Models
{
    public class Class1
    {

        [Required]
        public int java { get; set; }
        [Required]
        public int sql{ get; set; }
        [Required]
        public int andriod { get; set; }
        [Required]
        public int lb { get; set; }
        [Required]

        public int excel{ get; set; }
    
    }
}