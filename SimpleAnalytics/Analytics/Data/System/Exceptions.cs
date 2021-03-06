
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Exceptions
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The description for the exception.")]
            public static DataItem exceptionDescription = new DataItem("exceptionDescription");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The number of exceptions that were sent to Google Analytics.")]
            public static DataItem exceptions = new DataItem("exceptions");
                                      
            [DescriptionAttribute("The number of exceptions where isFatal is set to true.")]
            public static DataItem fatalExceptions = new DataItem("fatalExceptions");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The number of exceptions thrown divided by the number of screenviews. (ga:exceptions / ga:screenviews ) ")]
            public static DataItem exceptionsPerScreenview = new DataItem("exceptionsPerScreenview");
                                      
            [DescriptionAttribute("The number of fatal exceptions thrown divided by the number of screenviews. (ga:fatalExceptions / ga:screenviews ) ")]
            public static DataItem fatalExceptionsPerScreenview = new DataItem("fatalExceptionsPerScreenview");
                                      
            }
        }
    }
}
