using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Models
{
    public class Component: IAuditable, ISoftDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HtmlContent { get; set; }
    }
}
