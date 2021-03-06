
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Audience
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("Age bracket of visitor.")]
            public static DataItem visitorAgeBracket = new DataItem("visitorAgeBracket");
                                      
            [DescriptionAttribute("Gender of visitor.")]
            public static DataItem visitorGender = new DataItem("visitorGender");
                                      
            [DescriptionAttribute("Indicates that users are more likely to be interested in learning about the specified category, and more likely to be ready to purchase.")]
            public static DataItem interestOtherCategory = new DataItem("interestOtherCategory");
                                      
            [DescriptionAttribute("Indicates that users are more likely to be interested in learning about the specified category.")]
            public static DataItem interestAffinityCategory = new DataItem("interestAffinityCategory");
                                      
            [DescriptionAttribute("Indicates that users are more likely to be ready to purchase products or services in the specified category.")]
            public static DataItem interestInMarketCategory = new DataItem("interestInMarketCategory");
                                      
        }

        public sealed class Metrics
        {
            

            public sealed class Calculated
            {
                
            }
        }
    }
}
