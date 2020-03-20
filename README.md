# BxBlazor (Carbon Design System) Components

[![Build Status](https://dev.azure.com/cherkaouimouad/BxBlazor/_apis/build/status/BxBlazor?branchName=develop)](https://dev.azure.com/cherkaouimouad/BxBlazor/_build/latest?definitionId=53&branchName=master)

Blazor components using IBM's Carbon Design System components
<p align="center"><img src="img/carbon_design_system_white.png" width="250"></p>

🔎 **you can use dotnet new template to generate a starter project [BxBlazor Wasm-Hosted](#)  *a starter project using the blazor hosted template, and implementing sample Mediatr commands and queries.***

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

- dotnetcore 3.1 sdk
- aspnetcore 3.1 runtime

### Installing

A step by step series of examples that tell you how to get a development env running

First we need to install the BxBlazor component in our project:

```
$: dotnet add package BxBlazor
```

Next we add tags to our index.html in web assembly project or _Host.cshtml in a server project:

```html
.....
<!-- in the page header -->
<link href="https://unpkg.com/carbon-components/css/carbon-components.min.css" rel="stylesheet" />
```

```html
<!--  -->
<script src="https://unpkg.com/carbon-components/scripts/carbon-components.min.js"></script>

<!-- prismjs is used for code snippet highlighting -->
<script src="https://cdn.jsdelivr.net/npm/prismjs@1.19.0/prism.min.js"></script>

<script>
    window.InitComponent = (component) => {
        CarbonComponents[component].init();
    };

    window.highlightAll = function () {
        Prism.highlightAll();
    };

    window.bxModal_show = function (id) {
        var element = document.getElementById(id);
        window.modal = CarbonComponents.Modal.create(element);
        window.modal.show();
    };

    window.bxNotification_show = function (id) {    
        var element = document.getElementById(id);
        element.classList.add("show");
        this.setTimeout(() => element.classList.remove("show"), 3000);    
    };
</script>
<!-- this should be before _framework/blazor.server.js -->
<script src="_framework/blazor.server.js"></script>

```

Finally adding the ```using``` sections to *_imports.razor*:

```csharp
@using BxBlazor
@using BxBlazor.Components
@using BxBlazor.Components.UIShell
@using BxBlazor.Models
```

the last step is to compose our layout page using header, navigation panel etc...

```html
@inherits LayoutComponentBase
@inject IJSRuntime jsRuntime

    <div id="root">
        <BxUIShell 
                HeaderNavLinks="HeaderNavLinks"
                HeaderActions="HeaderActions"
                SwitcherLinks="SwitcherLinks"
                NavSections="Sections"
                NavMenuIdSuffix="primary"
                SideNavFixed="true">
            @ChildContent
        </BxUIShell>
    </div>
```

```cs 
@code {
    public class ShellState
    {
        public IEnumerable<HeaderNavLink> HeaderNavLinks { get; set; }
        public IEnumerable<SwitcherLink> SwitcherLinks { get; set; }
        public IEnumerable<NavMenuSection> Sections { get; set; }
        public IEnumerable<HeaderAction> HeaderActions { get; set; }

    }
    IEnumerable<HeaderNavLink> HeaderNavLinks
        = new List<HeaderNavLink> {
            new HeaderNavLink
            {
                Title = "test",
                Uri = "/"
            } ,
            new HeaderNavLink
            {
                Title = "with child items",
                ChildItems = new List<HeaderNavLink>
                {
                    new HeaderNavLink
                    {
                        Title = "item1",
                        Uri = "/"
                    }
                }
            }
        };
    
    IEnumerable<SwitcherLink> SwitcherLinks;
    
    IEnumerable<NavMenuSection> Sections
        = new List<NavMenuSection> {
            new NavMenuSection()
            {
                NavMenuItems = new List<NavMenuItem>
                {
                    new NavMenuItem
                    {
                        Title = "Home",
                        Type = "link",
                        Uri = "/"
                    }
                }
            }

        };

    IEnumerable<HeaderAction> HeaderActions
        = new List<HeaderAction> {
            new HeaderAction {
                Title = "Products",
                SwitchIdSuffix = "products"
            } };

}
```
## Running the project

we can the project locally jsut using dotnet cli:
```bash 
$: dotnet run
```

also you can host your application whther on azure storage public websites "preview", or for example in gh-pages this article explains steps to publish your application on gh-pages:

[hosting-blazor-webassembly-app-on-github-pages](https://dev.to/cirio/hosting-blazor-webassembly-app-on-github-pages-137k)


## Components

- BxAccordion
- BxModal
- BxTabs
- BxCheckbox
- BxDatatable
- BxStructuredList
- BxOverflowMenu

```
```

## Deployment

azure-pipelines.yml

## Built With

* [Carbon Design System Components](https://www.carbondesignsystem.com/) - Used for components and styling.
* [AspNetCore Blazor](https://nestjs.com/) - for the code behind.

## Authors

* **Mouad Cherkaoui** - *Initial work* - [mouadcherkaoui](https://github.com/mouadcherkaoui)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details