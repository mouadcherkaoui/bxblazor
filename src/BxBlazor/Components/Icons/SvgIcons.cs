using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BxBlazor.Components.Icons
{
    public class SvgIcons
    {
		public static RenderFragment IconWithStyle(MarkupString icon, string cssClass = "") =>
			((t) => t.AddMarkupContent(0, String.Format(icon.Value, cssClass)));

		public static MarkupString CarbonLogo(string cssClass = "") =>
			((MarkupString)
			$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32""
    viewBox=""0 0 32 32"" aria-hidden=""true"" style=""will-change: transform;"">
    <path
        d=""M13.5,30.8149a1.0011,1.0011,0,0,1-.4927-.13l-8.5-4.815A1,1,0,0,1,4,25V15a1,1,0,0,1,.5073-.87l8.5-4.815a1.0013,1.0013,0,0,1,.9854,0l8.5,4.815A1,1,0,0,1,23,15V25a1,1,0,0,1-.5073.87l-8.5,4.815A1.0011,1.0011,0,0,1,13.5,30.8149ZM6,24.417l7.5,4.2485L21,24.417V15.583l-7.5-4.2485L6,15.583Z"">
    </path>
    <path
        d=""M28,17H26V7.583L18.5,3.3345,10.4927,7.87,9.5073,6.13l8.5-4.815a1.0013,1.0013,0,0,1,.9854,0l8.5,4.815A1,1,0,0,1,28,7Z"">
    </path>
    <title>Carbon</title>
</svg>");

		public static MarkupString Menu20(string cssClass = "") =>
			((MarkupString)
			@$"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				width=""20px"" height=""20px"" viewBox=""0 0 20 20"" style=""enable-background:new 0 0 20 20;"" xml:space=""preserve"" {useCss(cssClass)}>
				<rect x=""2"" y=""14.8"" width=""16"" height=""1.2""/>
				<rect x=""2"" y=""11.2"" width=""16"" height=""1.2""/>
				<rect x=""2"" y=""7.6"" width=""16"" height=""1.2""/>
				<rect x=""2"" y=""4"" width=""16"" height=""1.2""/>
			</svg>");

		public static MarkupString Close20(string cssClass = "") =>
			((MarkupString)
			@$"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" aria-hidden=""true"" xmlns=""http://www.w3.org/2000/svg""
				width=""20"" height=""20"" viewBox=""0 0 32 32"" {useCss(cssClass)}
				style=""will-change: transform;"">
				<path d=""M24 9.4L22.6 8 16 14.6 9.4 8 8 9.4 14.6 16 8 22.6 9.4 24 16 17.4 22.6 24 24 22.6 17.4 16 24 9.4z"" ></path>
			</svg>");

		public static MarkupString ArrowRight20(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""20px"" height=""20px"" viewBox=""0 0 20 20"" style=""enable-background:new 0 0 20 20;"" xml:space=""preserve"" {useCss(cssClass)}>
			<style type=""text/css"">
				.st0{{fill:none;}}
			</style>
			<rect id=""_Transparent_Rectangle_"" class=""st0"" width=""20"" height=""20""/>
			<polygon points=""11.8,2.8 10.8,3.8 16.2,9.3 1,9.3 1,10.7 16.2,10.7 10.8,16.2 11.8,17.2 19,10 ""/>
			</svg>");

		public static MarkupString CaretDown(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""8px"" height=""4px"" viewBox=""0 0 8 4"" style=""enable-background:new 0 0 8 4;"" xml:space=""preserve"" {useCss(cssClass)}>
				<polygon points=""8,0 4,4 0,0 ""/>
			</svg>
			");

		public static MarkupString CaretLeft(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""8px"" height=""4px"" viewBox=""0 0 8 4"" style=""enable-background:new 0 0 8 4;"" xml:space=""preserve"" {useCss(cssClass)}>
				<polygon points=""8,0 4,4 0,0 ""/>
			</svg>
			");

		public static MarkupString CaretRight(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""8px"" height=""4px"" viewBox=""0 0 8 4"" style=""enable-background:new 0 0 8 4;"" xml:space=""preserve"" {useCss(cssClass)}>
				<polygon points=""8,0 4,4 0,0 ""/>
			</svg>
			");

		public static MarkupString CaretUp(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""8px"" height=""4px"" viewBox=""0 0 8 4"" style=""enable-background:new 0 0 8 4;"" xml:space=""preserve"" {useCss(cssClass)}>
				<polygon points=""0,4 4,0 8,4 ""/>
			</svg>
			");

		public static MarkupString Checkmark20(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""Layer_1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
					 width=""20px"" height=""20px"" viewBox=""0 0 20 20"" style=""enable-background:new 0 0 20 20;"" xml:space=""preserve"" {useCss(cssClass)}>
				<style type=""text/css"">
					.st0{{fill:none;}}
				</style>
				<g id=""_x32_0_px"">
					<g>
						<rect x=""0"" y=""0"" class=""st0"" width=""20"" height=""20""/>
					</g>
					<g>
						<polygon points=""8,13.2 3.6,8.8 2.7,9.7 7.1,14.1 8,15 16.5,6.5 15.6,5.6 		""/>
						<polygon points=""15.6,5.6 8,13.2 3.6,8.8 2.7,9.7 7.1,14.1 8,15 16.5,6.5 15.6,5.6 		""/>
					</g>
				</g>
			</svg>
			");
		public static MarkupString CheckmarkFilled20(string cssClass = "") =>
			((MarkupString)
			$@"<svg version = ""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""20px"" height=""20px"" viewBox=""0 0 20 20"" style=""enable-background:new 0 0 20 20;"" xml:space=""preserve"" {useCss(cssClass)}>
				<style type = ""text/css"" >
					.st0{{fill:none;}}
					.st1{{opacity:0;fill:#FFFFFF;fill-opacity:0;}}
				</style>
				<rect id = ""_Transparent_Rectangle_"" class=""st0"" width=""32"" height=""32""/>
				<path d = ""M10,1c-4.9,0-9,4.1-9,9s4.1,9,9,9s9-4,9-9S15,1,10,1z M8.7,13.5l-3.2-3.2l1-1l2.2,2.2l4.8-4.8l1,1L8.7,13.5z"" />
				< path id=""inner-path"" class=""st1"" d=""M8.7,13.5l-3.2-3.2l1-1l2.2,2.2l4.8-4.8l1,1L8.7,13.5z""/>
			</svg>			
			");

		public static MarkupString ChevronDown(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
				 width=""10px"" height=""6px"" viewBox=""0 0 10 6"" style=""enable-background:new 0 0 10 6;"" xml:space=""preserve"" {useCss(cssClass)}>
				<style type = ""text/css"" >
					.st0 {{

						fill: none;
					}}
				</style>
				<polygon points = ""5,6 0,1 0.7,0.3 5,4.6 9.3,0.3 10,1 "" />

				<rect id=""_x3C_Transparent_Rectangle_x3E_"" class=""st0"" width=""10"" height=""6"" />
			</svg>		
			");

		public static MarkupString ChevronLeft(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
					 width=""6px"" height=""10px"" viewBox=""0 0 6 10"" style=""enable-background:new 0 0 6 10;"" xml:space=""preserve"" {useCss(cssClass)}>
				<style type=""text/css"">
					.st0 {{
						fill: none;
					}}
				</style>
				<polygon points=""0,5 5,0 5.7,0.7 1.4,5 5.7,9.3 5,10 "" />

				<rect id=""_x3C_Transparent_Rectangle_x3E_"" class=""st0"" width=""6"" height=""10"" />

			</svg>		
			");

		public static MarkupString ChevronRight(string cssClass = "") =>
			((MarkupString)
			$@"<svg version=""1.1"" id=""icon"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
					 width=""6px"" height=""10px"" viewBox=""0 0 6 10"" style=""enable-background:new 0 0 6 10;"" xml:space=""preserve"" {useCss(cssClass)}>
				<style type=""text/css"">
					.st0 {{
						fill: none;
					}}
				</style>
				<polygon points=""6,5 1,10 0.3,9.3 4.6,5 0.3,0.7 1,0 "" />
				<rect id=""_x3C_Transparent_Rectangle_x3E_"" class=""st0"" width=""6"" height=""10"" />
			</svg>		
			");

		public static MarkupString ProductSwitcher20(string cssClass = "") =>
			((MarkupString)
			$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" style=""will-change: transform;"" {useCss(cssClass)}
					xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" width=""20"" height=""20"" viewBox=""0 0 32 32"">
				<path d=""M8.24 25.14L7 26.67a13.79 13.79 0 004.18 2.44l.69-1.87A12 12 0 018.24 25.14zM4.19 18l-2 .41A14.09 14.09 0 003.86 23L5.59 22A12.44 12.44 0 014.19 18zM11.82 4.76l-.69-1.87A13.79 13.79 0 007 5.33L8.24 6.86A12 12 0 0111.82 4.76zM5.59 10L3.86 9a14.37 14.37 0 00-1.64 4.59l2 .34A12.05 12.05 0 015.59 10zM16 2V4a12 12 0 010 24v2A14 14 0 0016 2z""></path>
			</svg>");
		private static string useCss(string cssClass)
		{
			return String.IsNullOrEmpty(cssClass) ? cssClass : $"class='{cssClass}'";
		}
	}


}
