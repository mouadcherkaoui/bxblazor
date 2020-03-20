# BxBlazor (Carbon Design System) Components

[![Build Status](https://dev.azure.com/cherkaouimouad/BxBlazor/_apis/build/status/BxBlazor?branchName=develop)](https://dev.azure.com/cherkaouimouad/BxBlazor/_build/latest?definitionId=53&branchName=master)

Blazor components using IBM's Carbon Design System components
<p align="center"><img src="img/carbon_design_system_white.png" width="250"></p>

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

Finally add the ```using``` sections to *_imports.razor*:

```csharp
@using BxBlazor
@using BxBlazor.Grid
@using BxBlazor.Components
@using BxBlazor.Components.UIShell
@using BxBlazor.Models
```

the next step is to use the UIShell in the main layout, since the components are using Carbon Design System components styles we should respect the layout structure, also to keep navigation state we will add a component that will hold the UIShell and in it we will add the ```@Body``` fragment to load views a kind of donut disposition: 

MainLayout.razor

```html
@inherits LayoutComponentBase

<div id="root">
    <ShellLayout>
        @Body
    </ShellLayout>
</div>
```

ShellLayout.razor

```html
@using BxBlazor.Components.UIShell

<BxUIShell
    HeaderNavLinks="HeaderNavLinks"
    HeaderActions="HeaderActions"
    SwitcherLinks="SwitcherLinks"
    NavSections="Sections"
    SideNavFixed="true">
    <div class="bx--content">
        @ChildContent
    </div>
</BxUIShell>
```

```cs 
@code {
    [Parameter]
    public RendreFragment ChildContent { get; set; }
    
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
                        Uri = "/",
                        ChildItems = new List<HeaderNavLink>
                    {
                            new HeaderNavLink
                            {
                                Title = "item1",
                                Uri = "/"
                            }
                        }
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
                    },
                    new NavMenuItem
                    {
                        Title = "Counter",
                        Type = "link",
                        Uri = "/counter"
                    },
                    new NavMenuItem
                    {
                        Title = "Fetch Data",
                        Type = "link",
                        Uri = "/fetchdata"
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
```

under the hood the shell it self is composed from three building blocks:

```html
<BxHeader prefix="bx" 
          UiSideNavFixed="true" 
          NavigationMenuIdSuffix="primary" 
          HeaderNavLinks="HeaderNavLinks" 
          HeaderActions="HeaderActions" 
          SideNavSections="NavSections">
</BxHeader>
```

```html
<BxProductSwitcher prefix="bx"
                   SwitcherLinks="SwitcherLinks"
                   IdSuffix="products">
</BxProductSwitcher>
```

```html
<BxNavigationMenu prefix="bx" 
                  NavMenuIdSuffix="NavMenuIdSuffix" 
                  NavMenuSections="NavSections" 
                  IsExpanded="false">
</BxNavigationMenu>
```

all is fine, now if you are using the blazor web assembly project template you have to make some changes:

- Index.razor

    ```html
    <BxGrid>
        <BxRow>
            <BxCol lg="10" offset="lg-1">
                <h1>Hello, world!</h1>

                Welcome to your new app.

                <SurveyPrompt Title="How is Blazor working for you?" />
            </BxCol>
        </BxRow>
    </BxGrid>
    ```

- Counter.razor 

    ```html
    <BxGrid>
        <BxRow>
            <BxCol lg="10" offset="lg-1">
                <h1>Counter</h1>

                <p>Current count: @currentCount</p>

                <BxButton prefix="bx" Type="BxButton.ButtonType.Primary" OnClick="IncrementCount" Text="Click me"></BxButton>
            </BxCol>
        </BxRow>
    </BxGrid>
    ```

- FetchData.rzor 

    ```html
    <BxGrid>
        <BxRow>
            <BxCol offset="lg-1" lg="10">
                <h3>Weahther Forecasts</h3>
                <p>This component demonstrates fetching data from the server.</p>
                @if (forecasts == null)
                {
                    <p><em>Loading...</em></p>
                }
                else
                {
                    <BxDataTableV2 TItem="WeatherForecast" Items="forecasts" IsSelectable="true">
                        <BatchActionsToolbar>
                            <BxDataTableV2_Toolbar OnPrimaryButtonClick="@(() => Console.WriteLine("BxTable primary button clicked!"))" />
                        </BatchActionsToolbar>
                    </BxDataTableV2>
                }
            </BxCol>
        </BxRow>
    </BxGrid>
    ```

finally a little change in the index.html file to show a styled loader component

```html
    <app>
        <div class="bx--loading-overlay">
            <div data-loading class="bx--loading">
                <svg class="bx--loading__svg" viewBox="-75 -75 150 150">
                    <title>Loading</title>
                    <circle class="bx--loading__stroke" cx="0" cy="0" r="37.5" />
                </svg>
            </div>
        </div>
    </app>
```

## Running the project

we can the project locally jsut using dotnet cli:
```bash 
$\> dotnet run
```

also you can host your application whther on azure storage public websites "preview", or for example in gh-pages this article explains steps to publish your application on gh-pages:

[hosting-blazor-webassembly-app-on-github-pages](https://dev.to/cirio/hosting-blazor-webassembly-app-on-github-pages-137k)


## Components

- BxAccordion
- BxButton
- BxTabs
- BxCheckbox
- BxStructuredList
- BxOverflowMenu
- BxDatatable
- BxModal


### BxAccordion 

```html
<BxAccordion Items="Items" />

@code {
    public IEnumerable<AccordionItem>
        Items { get; set; }
            = new List<AccordionItem>
            {
                new AccordionItem
                {
                    Title = "first pane",
                    Content = (tree) => tree.AddMarkupContent(0, "<p>a sample content with some tags in it, <strong>First item!</strong></p>")
                },
                new AccordionItem
                {
                    Title = "second pane",
                    Content = (tree) => tree.AddMarkupContent(0, "<p>a sample content with some tags in it, <strong>Second  item!</strong></p>")
                },
                new AccordionItem
                {
                    Title = "third pane",
                    Content = (tree) => tree.AddMarkupContent(0, "<p>a sample content with some tags in it, <strong>Third item!</strong></p>")
                }
        };

}
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