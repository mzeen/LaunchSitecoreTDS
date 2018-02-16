using Sitecore.Analytics.Aggregation.Data.Model;
using Sitecore.Analytics.Model;
using Sitecore.ExperienceAnalytics.Aggregation.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaunchSitecore.Analytics
{
    public class ByCountryVisit : VisitDimensionBase
    {
        public ByCountryVisit(Guid dimensionId): base(dimensionId)
        {

        }
        public override string GetKey(IVisitAggregationContext context)
        {
            return context.Visit.GeoData.Country;
        }

        public override bool HasDimensionKey(IVisitAggregationContext context)
        {
            return (!string.IsNullOrEmpty(context.Visit.GeoData.Country));
        }
    }
}