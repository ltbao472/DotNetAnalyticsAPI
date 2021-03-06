
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class UserTimings
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("A string for categorizing all user timing variables into logical groups for easier reporting purposes.")]
            public static DataItem userTimingCategory = new DataItem("userTimingCategory");
                                      
            [DescriptionAttribute("The name of the resources action being tracked.")]
            public static DataItem userTimingLabel = new DataItem("userTimingLabel");
                                      
            [DescriptionAttribute("A filter that can be used to add flexibility in visualizing user timings in the reports.")]
            public static DataItem userTimingVariable = new DataItem("userTimingVariable");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The total number of milliseconds for a user timing.")]
            public static DataItem userTimingValue = new DataItem("userTimingValue");
                                      
            [DescriptionAttribute("The number of hits that were sent for a particular userTimingCategory, userTimingLabel, and userTimingVariable.")]
            public static DataItem userTimingSample = new DataItem("userTimingSample");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The average amount of elapsed time. ((ga:userTimingValue / ga:userTimingSample / 1000) ) ")]
            public static DataItem avgUserTimingValue = new DataItem("avgUserTimingValue");
                                      
            }
        }
    }
}
