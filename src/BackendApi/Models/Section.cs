using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Models
{
    public class Section: IAuditable, ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegionId { get; set; }
        public string ClassName { get; set; }
        public string HtmlContent { get; set; }
    }
}
