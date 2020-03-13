using BxBlazor.Components.Icons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorwasm.Client
{
    public class Globals
    {
        public static string uishell_json =
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
                        {""Title"":""LinkedIn"",""Uri"":""https://linkedin.com/in/cherkaoui-mouad""},
                        {""Title"":""Github"",""Uri"":""https://github.com/mouadcherkaoui""},
                        {""Title"":""test03"",""Uri"":""https://facebook.com/cherkaoui.mouad""}
                    ]}],
                ""HeaderActions"":[
                        {""Title"":""switcher"", ""SwitchIdSuffix"":""products""}
                ]
            }";

        public static string UIShellStructure =
            @"{
        ""Sections"":[
            {""NavMenuItems"": [
                {""Title"":""Home"",""Uri"":""/"",""HasIcon"":false,""Type"":""link"",""IsActive"":true,""IsExpanded"":false,""SubMenuItems"":null},
                {""Title"":""UiShell"",""Uri"":""/uishell"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                {""Title"":""IBM Security-UIShell"", ""Uri"": ""/security-shell"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                {""Title"":""Components"",""Uri"":null,""HasIcon"":false,""Type"":""category"",""IsActive"":false,""IsExpanded"":true,
                    ""SubMenuItems"":[
                        {""Title"":""BxAccordion"",""Uri"":""/components/bx-accordion"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                        {""Title"":""BxButton"",""Uri"":""/components/bx-button"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                        {""Title"":""BxCheckbox"",""Uri"":""/components/bx-checkbox"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                        {""Title"":""BxDataTable"",""Uri"":""/components/bx-datatable"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                        {""Title"":""BxModal"",""Uri"":""/components/bx-modal"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                        {""Title"":""BxTabs"",""Uri"":""/components/bx-tabs"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null},
                        {""Title"":""BxStructuredList"",""Uri"":""/components/bx-structuredlist"",""HasIcon"":false,""Type"":""link"",""IsActive"":false,""IsExpanded"":false,""SubMenuItems"":null}
                    ]}
                ]}
            ],
            ""SwitcherLinks"":[
                {""Title"":""switcher01""},
                {""Title"":""switcher02""}],
            ""HeaderNavLinks"":[
                {""Title"":""test00"", ""ChildItems"":[
                    {""Title"":""LinkedIn"",""Uri"":""https://linkedin.com/in/cherkaoui-mouad""},
                    {""Title"":""Github"",""Uri"":""https://github.com/mouadcherkaoui""},
                    {""Title"":""test03"",""Uri"":""https://facebook.com/cherkaoui.mouad""}
                ]}],
            ""HeaderActions"":[
                    {""Title"":""switcher"", ""SwitchIdSuffix"":""products""}
            ]
        }";
    }
}
