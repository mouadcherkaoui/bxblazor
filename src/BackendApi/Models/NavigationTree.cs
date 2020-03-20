using NLayersApp.Persistence.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Models
{
    public class NavigationTree: IAuditable, ISoftDelete
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string Revision { get; set; }
        public string YmlDefinition { get; set; }
    }
}
