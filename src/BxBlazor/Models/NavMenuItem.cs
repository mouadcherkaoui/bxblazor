using System;
using System.Collections.Generic;
using System.Text;

namespace BxBlazor.Models
{
    public class NavMenuItem
    {
        public string Title { get; set; }
        public string Uri { get; set; }
        public bool HasIcon { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; } = false;
        public bool IsExpanded { get; set; } = false;
        public IEnumerable<NavMenuItem> SubMenuItems { get; set; }
    }
}
