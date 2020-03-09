using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorwasm.Client.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegionId { get; set; }
        public string ClassName { get; set; }
        public string HtmlContent { get; set; }
    }
}
