# BxBlazor (Carbon Design System) Components

[![Build Status](https://dev.azure.com/cherkaouimouad/BxBlazor/_apis/build/status/BxBlazor?branchName=develop)](https://dev.azure.com/cherkaouimouad/BxBlazor/_build/latest?definitionId=50&branchName=develop)

Blazor components using IBM's Carbon Design System components
<p align="center"><img src="img/carbon_design_system_white.png" width="250"></p>

🔎 **you can use dotnet new template to generate a starter project [BxBlazor Wasm-Hosted](https://nx.dev)  *a starter project using the blazor hosted template, and implementing sample Mediatr commands and queries.***

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
<link href="_content/BxBlazor/carbon-custom.css" rel="stylesheet"/>
<link href="_content/BxBlazor/carbon-components.min.css" rel="stylesheet"/>
```

```html
<!--  -->
<script src="_content/BxBlazor/carbon-components.min.js"></script>
<script src="_content/BxBlazor/carbon-init.js"></script>
<!-- this should be before _framework/blazor.server.js -->
<script src="_framework/blazor.server.js"></script>

```
Finally adding the ```using``` sections to *_imports.razor*:

```csharp
@using BxBlazor
@using BxBlazor.Components
@using BxBlazor.navigation
@using BxBlazor.Models
```

the last step is to compose our layout page using header, navigation panel etc...

```html
@inherits LayoutComponentBase
@inject IJSRuntime jsRuntime

    <div id="root">
        <Header>
            <Content>
                <LeftPanel Sections="NavigationSections"></LeftPanel>
                <RightPanel></RightPanel>
            </Content>
        </Header>
        <main class="bx--content">
            @Body
        </main>
    </div>
```
```cs 
@code {
    private Dictionary<string, SidenavItem[]> NavigationSections = new Dictionary<string, SidenavItem[]>()
    {
        {
            "Demos",
            new SidenavItem[] {
                new SidenavItem {
                    DisplayText = "Home",
                    Expanded = false,
                    HasChilds = false,
                    Link = "/"
                },
                new SidenavItem {
                    DisplayText = "Fetch Data",
                    Expanded = false,
                    HasChilds = false,
                    Link = "/fetchdata"
                },
                new SidenavItem {
                    DisplayText = "Counter",
                    Expanded = false,
                    HasChilds = false,
                    Link = "/counter"
                },
                new SidenavItem {
                    DisplayText = "Components",
                    Expanded = false,
                    HasChilds = true,
                    ChildItems = new SidenavItem[]
                {
                        new SidenavItem {
                            DisplayText = "BxAccordion",
                            Link = "components/bx-accordion"
                        },
                        new SidenavItem {
                            DisplayText = "BxDataTable",
                            Link = "components/bx-datatable"
                        },
                        new SidenavItem {
                            DisplayText = "BxModal",
                            Link = "components/bx-modal"
                        },
                        new SidenavItem {
                            DisplayText = "BxTabs",
                            Link = "components/bx-tabs"
                        },
                        new SidenavItem {
                            DisplayText = "BxStructuredList",
                            Link = "components/bx-structuredlist"
                        }
                    }
                }
            }
        }
    };

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }
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