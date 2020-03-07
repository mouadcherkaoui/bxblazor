using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BxBlazor.Models
{
    public class SelectOption
    {
        public string DisplayName { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }

    }
    public class SelectOption<TType>: SelectOption
    {
        public TType Item { get; set; }
    }
}
