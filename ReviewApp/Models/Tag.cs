using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual List<ReviewTag> ReviewTags { get; set; }
    }
}
