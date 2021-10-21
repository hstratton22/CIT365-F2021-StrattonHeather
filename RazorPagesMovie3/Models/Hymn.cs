using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie3.Models
{
    public class Hymn
    {
        public int ID { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Title { get; set; }
    }
}
