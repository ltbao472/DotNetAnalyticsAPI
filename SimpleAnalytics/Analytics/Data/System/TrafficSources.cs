
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class TrafficSources
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The path of the referring URL (e.g. document.referrer). If someone places a link to your property on their website, this element contains the path of the page that contains the referring link.")]
            public static DataItem referralPath = new DataItem("referralPath");
                                      
            [DescriptionAttribute("The full referring URL including the hostname and path.")]
            public static DataItem fullReferrer = new DataItem("fullReferrer");
                                      
            [DescriptionAttribute("When using manual campaign tracking, the filter of the utm_campaign campaign tracking parameter. When using AdWords autotagging, the name(s) of the online ad campaign that you use for your property. Otherwise the filter (not set) is used.")]
            public static DataItem campaign = new DataItem("campaign");
                                      
            [DescriptionAttribute("The source of referrals to your property. When using manual campaign tracking, the filter of the utm_source campaign tracking parameter. When using AdWords autotagging, the filter is google. Otherwise the domain of the source referring the visitor to your property (e.g. document.referrer). The filter may also contain a port address. If the visitor arrived without a referrer, the filter is (direct)")]
            public static DataItem source = new DataItem("source");
                                      
            [DescriptionAttribute("The type of referrals to your property. When using manual campaign tracking, the filter of the utm_medium campaign tracking parameter. When using AdWords autotagging, the filter is ppc. If the user comes from a search engine detected by Google Analytics, the filter is organic. If the referrer is not a search engine, the filter is referral. If the visitor came directly to the property, and document.referrer is empty, the filter is (none).")]
            public static DataItem medium = new DataItem("medium");
                                      
            [DescriptionAttribute("Combined values of ga:source and ga:medium.")]
            public static DataItem sourceMedium = new DataItem("sourceMedium");
                                      
            [DescriptionAttribute("When using manual campaign tracking, the filter of the utm_term campaign tracking parameter. When using AdWords autotagging or if a visitor used organic search to reach your property, the keywords used by visitors to reach your property. Otherwise the filter is (not set).")]
            public static DataItem keyword = new DataItem("keyword");
                                      
            [DescriptionAttribute("When using manual campaign tracking, the filter of the utm_content campaign tracking parameter. When using AdWords autotagging, the first line of the text for your online Ad campaign. If you are using mad libs for your AdWords content, this field displays the keywords you provided for the mad libs keyword match. Otherwise the filter is (not set)")]
            public static DataItem adContent = new DataItem("adContent");
                                      
            [DescriptionAttribute("Name of the social network. This can be related to the referring social network for traffic sources, or to the social network for social data hub activities. E.g. Google+, Blogger, etc.")]
            public static DataItem socialNetwork = new DataItem("socialNetwork");
                                      
            [DescriptionAttribute("Indicates visits that arrived to the property from a social source. The possible values are Yes or No where the first letter is capitalized.")]
            public static DataItem hasSocialSourceReferral = new DataItem("hasSocialSourceReferral");
                                      
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The number of organic searches that happened within a session. This metric is search engine agnostic.")]
            public static DataItem organicSearches = new DataItem("organicSearches");
                                      

            public sealed class Calculated
            {
                
            }
        }
    }
}
