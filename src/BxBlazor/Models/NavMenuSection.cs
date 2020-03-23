using System.Collections.Generic;

namespace BxBlazor.Models
{
    public class NavMenuSection
    {
        public string Title { get; set; }
        public IEnumerable<NavMenuItem> NavMenuItems { get; set; }
    }
}
