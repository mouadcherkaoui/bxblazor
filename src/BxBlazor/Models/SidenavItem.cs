using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BxBlazor.Models
{
    public class SidenavItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string Link { get; set; }
        public bool State { get; set; } = false;

        public bool HasChilds { get; set; } = false;
        public bool Expanded { get; set; } = false;
        public IEnumerable<SidenavItem> ChildItems { get; set; }
    }
}
