using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnoBergCMS.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get;set; }
        public string DateTime { get; set; }
    }
}
