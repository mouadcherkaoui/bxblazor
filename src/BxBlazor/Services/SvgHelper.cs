using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BxBlazor.Services
{
    public class SvgHelper
    {
        private readonly HttpClient httpClient;

        public MarkupString BitBucket { get; set; }
        public MarkupString Jenkins { get; set; }
        public MarkupString Github { get; set; }
        public MarkupString Gitlab { get; set; }
        public MarkupString Docker { get; set; }
        public MarkupString Java { get; set; }
        public MarkupString Npm { get; set; }
        public MarkupString NuGet { get; set; }
        public MarkupString Python { get; set; }
        public MarkupString Ruby { get; set; }

        public MarkupString this[string index]
        {
            get => Icons.ContainsKey(index) ? Icons[index] : new MarkupString("");
        }
        public SvgHelper(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task LoadIconsAsync()
        {
            BitBucket = new MarkupString(await httpClient.GetStringAsync("img/bitbucket.svg"));
            Jenkins = new MarkupString(await httpClient.GetStringAsync("img/jenkins.svg"));
            Github = new MarkupString(await httpClient.GetStringAsync("img/github.svg"));
            Gitlab = new MarkupString(await httpClient.GetStringAsync("img/gitlab.svg"));
            Docker = new MarkupString(await httpClient.GetStringAsync("img/docker.svg"));
            Java = new MarkupString(await httpClient.GetStringAsync("img/java.svg"));
            Npm = new MarkupString(await httpClient.GetStringAsync("img/npm.svg"));
            NuGet = new MarkupString(await httpClient.GetStringAsync("img/nuget.svg"));
            Python = new MarkupString(await httpClient.GetStringAsync("img/python.svg"));
            Ruby = new MarkupString(await httpClient.GetStringAsync("img/ruby.svg"));
        }

        public async Task LoadIconsAsync(params string[] icons)
        {
            foreach (var icon in icons)
            {
                Icons.Add(icon, new MarkupString(await httpClient.GetStringAsync($"svg/{icon}.svg")));
            }
        }

        public Dictionary<string, MarkupString> Icons { get; set; } = new Dictionary<string, MarkupString>();
    }

}
