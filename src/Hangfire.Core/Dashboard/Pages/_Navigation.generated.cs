﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Dashboard\Pages\_Navigation.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\_Navigation.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Navigation : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





            
            #line 5 "..\..\Dashboard\Pages\_Navigation.cshtml"
 if (NavigationMenu.Items.Count > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <ul class=\"nav navbar-nav\">\r\n");


            
            #line 8 "..\..\Dashboard\Pages\_Navigation.cshtml"
         foreach (var item in NavigationMenu.Items)
        {
            var itemValue = item(this);

            if (itemValue == null) { continue; }


            
            #line default
            #line hidden
WriteLiteral("            <li class=\"");


            
            #line 14 "..\..\Dashboard\Pages\_Navigation.cshtml"
                   Write(itemValue.Active ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <a href=\"");


            
            #line 15 "..\..\Dashboard\Pages\_Navigation.cshtml"
                    Write(itemValue.Url);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    ");


            
            #line 16 "..\..\Dashboard\Pages\_Navigation.cshtml"
               Write(itemValue.Text);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 18 "..\..\Dashboard\Pages\_Navigation.cshtml"
                     foreach (var metric in itemValue.GetAllMetrics())
                    {
                        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Dashboard\Pages\_Navigation.cshtml"
                   Write(RenderPartial(new InlineMetric(metric)));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Dashboard\Pages\_Navigation.cshtml"
                                                                
                    }

            
            #line default
            #line hidden
WriteLiteral("                </a>\r\n            </li>\r\n");


            
            #line 24 "..\..\Dashboard\Pages\_Navigation.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");


            
            #line 26 "..\..\Dashboard\Pages\_Navigation.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
