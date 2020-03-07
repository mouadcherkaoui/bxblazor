using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BxBlazor.Models
{
    public class AccordionItem
    {
        public string Title { get; set; }
        public RenderFragment Content { get; set; }
    }
}
