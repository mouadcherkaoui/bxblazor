using System;
using System.Collections.Generic;
using System.Text;

namespace BxBlazor.Models
{
    public class HeaderNavLink
    {
        public string Title { get; set; }
        public string Uri { get; set; }
        public bool Expanded { get; set; }
        public IEnumerable<HeaderNavLink> ChildItems { get; set; }
    }
}
