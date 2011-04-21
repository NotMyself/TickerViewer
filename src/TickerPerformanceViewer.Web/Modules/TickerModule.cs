using System.Collections.Generic;
using Nancy;
using TickerPerformanceViewer.Web.Models;
using TickerPerformanceViewer.Web.Services;

namespace TickerPerformanceViewer.Web.Modules
{
    public class TickerModule : AppModule
    {
        public TickerModule(ILookUpPrices lookUp) : base("/ticker")
        {
            Get["/{symbol}"] = parameters =>
                                   {
                                       IEnumerable<DailyPrice> prices = lookUp.GetFor(parameters.symbol);
                                       return Response.AsJson(prices);
                                   };
        }
    }
}