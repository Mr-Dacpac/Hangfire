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
    
    #line 2 "..\..\Dashboard\Pages\DashboardPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\DashboardPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\DashboardPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\DashboardPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\DashboardPage.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class DashboardPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Dashboard\Pages\DashboardPage.cshtml"
  
    Layout = new LayoutPage("Dashboard");
    IDictionary<DateTime, long> succeeded = null;
    IDictionary<DateTime, long> failed = null;

    var period = Query("period") ?? "day";

    var monitor = Storage.GetMonitoringApi();
    if ("week".Equals(period, StringComparison.OrdinalIgnoreCase))
    {
        succeeded = monitor.SucceededByDatesCount();
        failed = monitor.FailedByDatesCount();
    }
    else if ("day".Equals(period, StringComparison.OrdinalIgnoreCase))
    {
        succeeded = monitor.HourlySucceededJobs();
        failed = monitor.HourlyFailedJobs();
    }


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"page-header\"" +
">Dashboard</h1>\r\n");


            
            #line 31 "..\..\Dashboard\Pages\DashboardPage.cshtml"
         if (Metrics.Count > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"row\">\r\n");


            
            #line 34 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                 foreach (var metric in Metrics)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div class=\"col-md-2\">\r\n                        ");


            
            #line 37 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                   Write(RenderPartial(new BlockMetric(metric)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");


            
            #line 39 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 41 "..\..\Dashboard\Pages\DashboardPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral(@"        <h3>Realtime graph</h3>
        <div id=""realtimeGraph""></div>
        <div style=""display: none;"">
            <span data-metric=""succeeded:count""></span>
            <span data-metric=""failed:count""></span>
        </div>

        <h3>
            <div class=""btn-group pull-right"" style=""margin-top: 2px;"">
                <a href=""?period=day"" class=""btn btn-sm btn-default ");


            
            #line 51 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                                                                Write("day".Equals(period, StringComparison.OrdinalIgnoreCase) ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    Day\r\n                </a>\r\n                <a href=\"?peri" +
"od=week\" class=\"btn btn-sm btn-default ");


            
            #line 54 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                                                                 Write("week".Equals(period, StringComparison.OrdinalIgnoreCase) ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">Week</a>\r\n            </div>\r\n            History graph\r\n        </h3>\r\n\r\n");


            
            #line 59 "..\..\Dashboard\Pages\DashboardPage.cshtml"
         if (succeeded != null && failed != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div id=\"historyGraph\"\r\n                 data-succeeded=\"");


            
            #line 62 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                            Write(JsonConvert.SerializeObject(succeeded));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                 data-failed=\"");


            
            #line 63 "..\..\Dashboard\Pages\DashboardPage.cshtml"
                         Write(JsonConvert.SerializeObject(failed));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            </div>\r\n");


            
            #line 65 "..\..\Dashboard\Pages\DashboardPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
