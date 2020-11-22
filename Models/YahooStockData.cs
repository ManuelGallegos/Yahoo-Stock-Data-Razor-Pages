using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yahoo_Stock_Data_Razor_Pages.Models
{
    public class YahooStockData
    {
        public string Ticker { get; set; }
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double CloseAdj { get; set; }
        public double Volume { get; set; }
    }
}
