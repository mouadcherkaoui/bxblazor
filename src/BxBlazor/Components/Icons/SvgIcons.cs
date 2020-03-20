using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BxBlazor.Components.Icons
{
    public static class SvgIcons
    {
		public static RenderFragment IconWithStyle(MarkupString icon, string cssClass = "") =>
			((t) => t.AddMarkupContent(0, String.Format(icon.Value, cssClass)));

		public static class Logos
		{
			public static MarkupString CarbonDesignSystem(string cssClass = "") =>
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
			public static MarkupString Skype(string cssClass) =>
				((MarkupString)
				$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32""
					viewBox=""0 0 32 32"" aria-hidden=""true"" style=""will-change: transform;"" {useCss(cssClass)}>
					<path
						d = ""M27.91,17.88A11.63,11.63,0,0,0,28.06,16,12.06,12.06,0,0,0,16,3.94a11.63,11.63,0,0,0-1.88.15,7.29,7.29,0,0,0-10,10A11.63,11.63,0,0,0,3.94,16,12.06,12.06,0,0,0,16,28.06a11.63,11.63,0,0,0,1.88-.15,7.29,7.29,0,0,0,10-10Zm-6.18,3.6a5,5,0,0,1-2.24,1.73,9,9,0,0,1-3.48.62A8.41,8.41,0,0,1,12,23a5.2,5.2,0,0,1-1.82-1.63,3.59,3.59,0,0,1-.7-2,1.36,1.36,0,0,1,.43-1A1.56,1.56,0,0,1,11,18a1.38,1.38,0,0,1,.91.32,2.5,2.5,0,0,1,.63.94,5.83,5.83,0,0,0,.66,1.18,2.61,2.61,0,0,0,1,.78,3.87,3.87,0,0,0,1.69.31,4,4,0,0,0,2.34-.62,1.8,1.8,0,0,0,.89-1.53,1.54,1.54,0,0,0-.47-1.17,3.09,3.09,0,0,0-1.25-.7c-.52-.17-1.21-.34-2.08-.53A16,16,0,0,1,12.41,16a4.78,4.78,0,0,1-1.89-1.4,3.5,3.5,0,0,1-.7-2.21,3.65,3.65,0,0,1,.74-2.24,4.7,4.7,0,0,1,2.14-1.5A9.51,9.51,0,0,1,16,8.17a8.63,8.63,0,0,1,2.59.35,5.81,5.81,0,0,1,1.83.92,3.91,3.91,0,0,1,1.06,1.21,2.62,2.62,0,0,1,.34,1.25,1.4,1.4,0,0,1-.43,1,1.43,1.43,0,0,1-1.07.46,1.25,1.25,0,0,1-.89-.28,3.36,3.36,0,0,1-.65-.87,3.79,3.79,0,0,0-1.05-1.31,3.13,3.13,0,0,0-1.95-.46,3.64,3.64,0,0,0-2,.5,1.44,1.44,0,0,0-.76,1.2,1.15,1.15,0,0,0,.25.75,2.21,2.21,0,0,0,.72.55,4.74,4.74,0,0,0,.92.36c.32.09.84.22,1.57.39.92.2,1.74.42,2.49.66a7.61,7.61,0,0,1,1.9.88,3.59,3.59,0,0,1,1.23,1.31A4,4,0,0,1,22.5,19,4.24,4.24,0,0,1,21.73,21.48Z"" >

					</ path >

					< title > Logo skype</title>
				</svg>");

			public static MarkupString Slack(string cssClass = "") =>
				((MarkupString)
				$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32""
					viewBox=""0 0 32 32"" aria-hidden=""true"" style=""will-change: transform;"" {useCss(cssClass)}>
					<path
						d=""M9.0423 19.1661A2.5212 2.5212 0 116.5212 16.645H9.0423zM10.3127 19.1661a2.5212 2.5212 0 015.0423 0v6.3127a2.5212 2.5212 0 11-5.0423 0zM12.8339 9.0423A2.5212 2.5212 0 1115.355 6.5212V9.0423zM12.8339 10.3127a2.5212 2.5212 0 010 5.0423H6.5212a2.5212 2.5212 0 110-5.0423zM22.9577 12.8339a2.5212 2.5212 0 112.5211 2.5211H22.9577zM21.6873 12.8339a2.5212 2.5212 0 01-5.0423 0V6.5212a2.5212 2.5212 0 115.0423 0zM19.1661 22.9577a2.5212 2.5212 0 11-2.5211 2.5211V22.9577zM19.1661 21.6873a2.5212 2.5212 0 010-5.0423h6.3127a2.5212 2.5212 0 110 5.0423z"">
					</path>
					<title>Logo slack</title>
				</svg>");

			public static MarkupString Github(string cssClass = "") =>
				((MarkupString)
				$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32""
					viewBox=""0 0 32 32"" aria-hidden=""true"" style=""will-change: transform;"" {useCss(cssClass)}>
					<path fill-rule=""evenodd""
						d=""M16,2a14,14,0,0,0-4.43,27.28c.7.13,1-.3,1-.67s0-1.21,0-2.38c-3.89.84-4.71-1.88-4.71-1.88A3.71,3.71,0,0,0,6.24,22.3c-1.27-.86.1-.85.1-.85A2.94,2.94,0,0,1,8.48,22.9a3,3,0,0,0,4.08,1.16,2.93,2.93,0,0,1,.88-1.87c-3.1-.36-6.37-1.56-6.37-6.92a5.4,5.4,0,0,1,1.44-3.76,5,5,0,0,1,.14-3.7s1.17-.38,3.85,1.43a13.3,13.3,0,0,1,7,0c2.67-1.81,3.84-1.43,3.84-1.43a5,5,0,0,1,.14,3.7,5.4,5.4,0,0,1,1.44,3.76c0,5.38-3.27,6.56-6.39,6.91a3.33,3.33,0,0,1,.95,2.59c0,1.87,0,3.38,0,3.84s.25.81,1,.67A14,14,0,0,0,16,2Z"">
					</path>
					<title>Logo github</title>
				</svg>");

			public static MarkupString LinkedIn(string cssClass = "") =>
				((MarkupString)
				$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32""
					viewBox=""0 0 32 32"" aria-hidden=""true"" style=""will-change: transform;"" {useCss(cssClass)}>
					<path
						d=""M26.21,4H5.79A1.78,1.78,0,0,0,4,5.73V26.2a1.77,1.77,0,0,0,1.79,1.73H26.21A1.77,1.77,0,0,0,28,26.2V5.73A1.78,1.78,0,0,0,26.21,4ZM11.11,24.41H7.59V13h3.52Zm-1.72-13A2.07,2.07,0,0,1,7.32,9.39,2,2,0,0,1,9.39,7.32a2.07,2.07,0,0,1,0,4.13ZM24.48,24.34H21V18.76c0-1.33,0-3.06-1.86-3.06S17,17.16,17,18.63v5.65H13.44V13h3.32V14.5h.07a3.72,3.72,0,0,1,3.39-1.86c3.59,0,4.26,2.4,4.26,5.45Z"">
					</path>
					<title>Logo linkedin</title>
				</svg>");

			public static MarkupString Facebook(string cssClass = "") =>
				((MarkupString)
				$@"<svg focusable=""false"" preserveAspectRatio=""xMidYMid meet"" xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32""
					viewBox=""0 0 32 32"" aria-hidden=""true"" style=""will-change: transform;"" {useCss(cssClass)}>
					<path
						d=""M26.67,4H5.33A1.34,1.34,0,0,0,4,5.33V26.67A1.34,1.34,0,0,0,5.33,28H16.82V18.72H13.7V15.09h3.12V12.42c0-3.1,1.89-4.79,4.67-4.79.93,0,1.86,0,2.79.14V11H22.37c-1.51,0-1.8.72-1.8,1.77v2.31h3.6l-.47,3.63H20.57V28h6.1A1.34,1.34,0,0,0,28,26.67V5.33A1.34,1.34,0,0,0,26.67,4Z"">
					</path>
					<title>Logo facebook</title>
				</svg>");
		}

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
