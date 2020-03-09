using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorwasm.Client.Models
{
    public class Page 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Route { get; set; }
        public string Description { get; set; }
        public string RawHtml { get; set; }

        public IEnumerable<Section> Sections { get; set; }
        public string CsRegions { get; set; }
    }

}
