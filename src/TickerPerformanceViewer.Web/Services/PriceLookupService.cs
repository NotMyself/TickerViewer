using System;
using System.Collections.Generic;
using System.Net;
using FileHelpers;
using FizzWare.NBuilder;
using TickerPerformanceViewer.Web.Models;

namespace TickerPerformanceViewer.Web.Services
{
    public interface ILookUpPrices
    {
        IEnumerable<DailyPrice> GetFor(string symbol);
    }

    public class PriceLookupService : ILookUpPrices
    {
        private readonly string yahooFinanceQuery = "http://ichart.finance.yahoo.com/table.csv?s={0}";
        private WebClient webClient;
        FileHelperEngine<DailyPrice> reader;

        public PriceLookupService()
        {
            webClient = new WebClient();
            reader = new FileHelperEngine<DailyPrice>();
        }
        public IEnumerable<DailyPrice> GetFor(string symbol)
        {
            var uri = string.Format(yahooFinanceQuery, symbol);
            var rawData = webClient.DownloadString(uri);
            return reader.ReadString(rawData);
        }
    }
}