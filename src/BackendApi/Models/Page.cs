using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Models
{
    public class Page: IAuditable, ISoftDelete
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
