using Sitecore.Analytics.Aggregation.Data.Model;
using Sitecore.Analytics.Model;
using Sitecore.ExperienceAnalytics.Aggregation.Dimensions;
using Sitecore.ExperienceAnalytics.Api.Response.DimensionKeyTransformers;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaunchSitecore.Analytics
{
    class BrowserVersionTransformer : IDimensionKeyTransformer
    {

        public string UnknownLabel
        {
            get { return "unknown Browser"; }
        }

        public string Transform(string key, Language language)
        {
            return key.Replace('-', ' ');
        }
    }
}