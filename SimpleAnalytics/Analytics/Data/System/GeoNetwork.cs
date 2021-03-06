
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class GeoNetwork
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The continents of property visitors, derived from IP addresses.")]
            public static DataItem continent = new DataItem("continent");
                                      
            [DescriptionAttribute("The sub-continent of visitors, derived from IP addresses. For example, Polynesia or Northern Europe.")]
            public static DataItem subContinent = new DataItem("subContinent");
                                      
            [DescriptionAttribute("The countries of website visitors, derived from IP addresses.")]
            public static DataItem country = new DataItem("country");
                                      
            [DescriptionAttribute("The region of visitors to your property, derived from IP addresses. In the U.S., a region is a state, such as New York.")]
            public static DataItem region = new DataItem("region");
                                      
            [DescriptionAttribute("The Designated Market Area (DMA) from where traffic arrived on your property.")]
            public static DataItem metro = new DataItem("metro");
                                      
            [DescriptionAttribute("The cities of property visitors, derived from IP addresses.")]
            public static DataItem city = new DataItem("city");
                                      
            [DescriptionAttribute("The approximate latitude of the visitors city. Derived from IP address. Locations north of the equator are represented by positive values and locations south of the equator by negative values.")]
            public static DataItem latitude = new DataItem("latitude");
                                      
            [DescriptionAttribute("The approximate longitude of the visitors city. Derived from IP address. Locations east of the meridian are represented by positive values and locations west of the meridian by negative values.")]
            public static DataItem longitude = new DataItem("longitude");
                                      
            [DescriptionAttribute("The domain name of the ISPs used by visitors to your property. This is derived from the domain name registered to the IP address.")]
            public static DataItem networkDomain = new DataItem("networkDomain");
                                      
            [DescriptionAttribute("The name of service providers used to reach your property. For example, if most visitors to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.")]
            public static DataItem networkLocation = new DataItem("networkLocation");
                                      
        }

        public sealed class Metrics
        {
            

            public sealed class Calculated
            {
                
            }
        }
    }
}
