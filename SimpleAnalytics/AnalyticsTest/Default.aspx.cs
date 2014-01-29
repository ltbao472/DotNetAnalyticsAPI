﻿using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnalyticsTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Analytics.AnalyticsManager manager = new Analytics.AnalyticsManager(Server.MapPath("~/bin/privatekey.p12"), "YOUR_EMAIL");
            manager.LoadAnalyticsProfiles();

            //that's the number after the p in google analytics url
            //ps. you need to give your email account taken from the service access from the web control panel in google analytics
            manager.SetDefaultAnalyticProfile("80425770");
            List<Analytics.Data.DataItem> metrics = new List<Analytics.Data.DataItem>();
            metrics.Add(Analytics.Data.Visitor.Metrics.visitors);
            metrics.Add(Analytics.Data.Session.Metrics.visits);
            List<Analytics.Data.DataItem> dimensions = new List<Analytics.Data.DataItem>();
            dimensions.Add(Analytics.Data.GeoNetwork.Dimensions.country);
            dimensions.Add(Analytics.Data.GeoNetwork.Dimensions.city);

            
            System.Data.DataTable table = manager.GetGaDataTable(DateTime.Today.AddDays(-3), DateTime.Today, metrics, dimensions, null, metrics);
            GridViewControl.DataSource = table;
            GridViewControl.DataBind();
        }
    }
}