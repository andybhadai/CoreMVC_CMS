using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace TechnoBergCMS.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name = "Blog title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Blog text")]
        public string Text { get; set; }
        public string Author { get;set; }
        public string DateTime { get; set; }
    }
}
