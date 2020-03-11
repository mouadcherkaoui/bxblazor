using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorwasm.Client
{
    public class Globals
    {
        public static string UIShellStructure =
            @"{
            ""Sections"":[   
                {""NavMenuItems"": [
                    {""Title"":""navmenu01"",""Uri"":null,""HasIcon"":false,""Type"":""link"",""IsActive"":true,""IsExpanded"":false,""SubMenuItems"":null},
                    {""Title"":""navmenu01"",""Uri"":null,""HasIcon"":false,""Type"":""category"",""IsActive"":false,""IsExpanded"":true,
                        ""SubMenuItems"":[
                            {""Title"":""submenu01"",""Uri"":null,""HasIcon"":false,""Type"":""link"",""IsActive"":true,""IsExpanded"":false,""SubMenuItems"":null},
                            {""Title"":""submenu01"",""Uri"":null,""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null}
                        ]}
                    ]}
                ],
                ""SwitcherLinks"":[
                    {""Title"":""switcher01""}],
                ""HeaderNavLinks"":[
                    {""Title"":""test00"", ""ChildItems"":[
                        {""Title"":""test01"",""Uri"":""/components/bx-accordion""},
                        {""Title"":""test02"",""Uri"":""/components/bx-accordion""},
                        {""Title"":""test03"",""Uri"":""/components/bx-accordion""}
                    ]}],
                ""HeaderActions"":[
                        {""Title"":""switcher"", ""SwitchIdSuffix"":""products""}
                ]
            }";
    }
}
