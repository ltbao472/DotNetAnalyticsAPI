
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class SiteSpeed
    {
        public sealed class Dimensions
        {
            
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("Total Page Load Time is the amount of time (in milliseconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser.")]
            public static DataItem pageLoadTime = new DataItem("pageLoadTime");
                                      
            [DescriptionAttribute("The sample set (or count) of pageviews used to calculate the average page load time.")]
            public static DataItem pageLoadSample = new DataItem("pageLoadSample");
                                      
            [DescriptionAttribute("The total amount of time (in milliseconds) spent in DNS lookup for this page among all samples.")]
            public static DataItem domainLookupTime = new DataItem("domainLookupTime");
                                      
            [DescriptionAttribute("The total amount of time (in milliseconds) to download this page among all samples.")]
            public static DataItem pageDownloadTime = new DataItem("pageDownloadTime");
                                      
            [DescriptionAttribute("The total amount of time (in milliseconds) spent in redirects before fetching this page among all samples. If there are no redirects, the filter for this metric is expected to be 0.")]
            public static DataItem redirectionTime = new DataItem("redirectionTime");
                                      
            [DescriptionAttribute("The total amount of time (in milliseconds) spent in establishing TCP connection for this page among all samples.")]
            public static DataItem serverConnectionTime = new DataItem("serverConnectionTime");
                                      
            [DescriptionAttribute("The total amount of time (in milliseconds) your server takes to respond to a user request among all samples, including the network time from users location to your server.")]
            public static DataItem serverResponseTime = new DataItem("serverResponseTime");
                                      
            [DescriptionAttribute("The sample set (or count) of pageviews used to calculate the averages for site speed metrics. This metric is used in all site speed average calculations including avgDomainLookupTime, avgPageDownloadTime, avgRedirectionTime, avgServerConnectionTime, and avgServerResponseTime.")]
            public static DataItem speedMetricsSample = new DataItem("speedMetricsSample");
                                      
            [DescriptionAttribute("The time the browser takes (in milliseconds) to parse the document (DOMInteractive), including the network time from the users location to your server. At this time, the user can interact with the Document Object Model even though it is not fully loaded.")]
            public static DataItem domInteractiveTime = new DataItem("domInteractiveTime");
                                      
            [DescriptionAttribute("The time the browser takes (in milliseconds) to parse the document and execute deferred and parser-inserted scripts (DOMContentLoaded), including the network time from the users location to your server. Parsing of the document is finished, the Document Object Model is ready, but referenced style sheets, images, and subframes may not be finished loading. This event is often the starting point for javascript framework execution, e.g., JQuerys onready() callback, etc.")]
            public static DataItem domContentLoadedTime = new DataItem("domContentLoadedTime");
                                      
            [DescriptionAttribute("The sample set (or count) of pageviews used to calculate the averages for site speed DOM metrics. This metric is used in the avgDomContentLoadedTime and avgDomInteractiveTime calculations.")]
            public static DataItem domLatencyMetricsSample = new DataItem("domLatencyMetricsSample");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average amount of time (in seconds) it takes for pages from the sample set to load, from initiation of the pageview (e.g. click on a page link) to load completion in the browser. ((ga:pageLoadTime / ga:pageLoadSample / 1000) ) ")]
            public static DataItem avgPageLoadTime = new DataItem("avgPageLoadTime");
                                      
            [DescriptionAttribute("The average amount of time (in seconds) spent in DNS lookup for this page. ((ga:domainLookupTime / ga:speedMetricsSample / 1000) ) ")]
            public static DataItem avgDomainLookupTime = new DataItem("avgDomainLookupTime");
                                      
            [DescriptionAttribute("The average amount of time (in seconds) to download this page. ((ga:pageDownloadTime / ga:speedMetricsSample / 1000) ) ")]
            public static DataItem avgPageDownloadTime = new DataItem("avgPageDownloadTime");
                                      
            [DescriptionAttribute("The average amount of time (in seconds) spent in redirects before fetching this page. If there are no redirects, the filter for this metric is expected to be 0. ((ga:redirectionTime / ga:speedMetricsSample / 1000) ) ")]
            public static DataItem avgRedirectionTime = new DataItem("avgRedirectionTime");
                                      
            [DescriptionAttribute("The average amount of time (in seconds) spent in establishing TCP connection for this page. ((ga:serverConnectionTime / ga:speedMetricsSample / 1000) ) ")]
            public static DataItem avgServerConnectionTime = new DataItem("avgServerConnectionTime");
                                      
            [DescriptionAttribute("The average amount of time (in seconds) your server takes to respond to a user request, including the network time from users location to your server. ((ga:serverResponseTime / ga:speedMetricsSample / 1000) ) ")]
            public static DataItem avgServerResponseTime = new DataItem("avgServerResponseTime");
                                      
            [DescriptionAttribute("The average time (in seconds) it takes the browser to parse the document and execute deferred and parser-inserted scripts including the network time from the users location to your server. ((ga:domInteractiveTime / ga:domLatencyMetricsSample / 1000) ) ")]
            public static DataItem avgDomInteractiveTime = new DataItem("avgDomInteractiveTime");
                                      
            [DescriptionAttribute("The average time (in seconds) it takes the browser to parse the document. ((ga:domContentLoadedTime / ga:domLatencyMetricsSample / 1000) ) ")]
            public static DataItem avgDomContentLoadedTime = new DataItem("avgDomContentLoadedTime");
                                      
            }
        }
    }
}
