using System;
using FileHelpers;

namespace TickerPerformanceViewer.Web.Models
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public class DailyPrice
    {
        //[FieldConverter(ConverterKind.Date, "yyyy-MM-dd")] 
        public string Date;
        public float Open;
        public float High;
        public float Low;
        public float Close;
        public int Volume;
        public float AdjustedClose;
    }
}