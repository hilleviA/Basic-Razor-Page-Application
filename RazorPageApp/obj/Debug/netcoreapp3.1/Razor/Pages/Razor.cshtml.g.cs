#pragma checksum "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fdaedfff881a72eb943be63fb5413278f468a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Razor), @"mvc.1.0.razor-page", @"/Pages/Razor.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fdaedfff881a72eb943be63fb5413278f468a57", @"/Pages/Razor.cshtml")]
    public class Pages_Razor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
  

    ViewData["Title"] = "Razor";

    //Hittar veckodag
    DayOfWeek today = DateTime.Today.DayOfWeek;

    //String med kurser
    string[] courses = { "DT057G, Webbutveckling I", "DT084G, Introduktion till programmering i JavaScript", "GD008G, Typografi och form för webb", "DT163G, Bildbehandling för webb", "DT003G, Databaser", "DT193G, Webbutveckling II", "DT152G, Webbdesign med CMS", "DT162G, JavaScriptbaserad webbutveckling" };


#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Kurser som jag läst</h3>\r\n<ul>\r\n");
#nullable restore
#line 16 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
      
        foreach (var course in courses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 19 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
           Write(course);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<h3>Bra att veta: </h3>\r\n");
#nullable restore
#line 25 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
  
    if (today == DayOfWeek.Monday)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Idag är det månadg</p>\r\n");
#nullable restore
#line 29 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Idag är det inte måndag</p>\r\n");
#nullable restore
#line 33 "C:\Users\Hillevi Annfält\Desktop\MIUN\ASP.NET\Moment 1.2\RazorPageApp\RazorPageApp\Pages\Razor.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPageApp.Pages.CoursesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageApp.Pages.CoursesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPageApp.Pages.CoursesModel>)PageContext?.ViewData;
        public RazorPageApp.Pages.CoursesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
