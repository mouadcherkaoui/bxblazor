using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace BxBlazor.Events
{
    public class SearchEventArgs : KeyboardEventArgs
    {
        public SearchEventArgs(KeyboardEventArgs args, string searchValue)
        {
            Key = args.Key;
            Location = args.Location;
            MetaKey = args.MetaKey;
            Repeat = args.Repeat;
            SearchValue = searchValue;
        }
        public string SearchValue { get; set; }
    }
}
