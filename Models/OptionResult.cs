using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yahoo_Stock_Data_Razor_Pages.Models
{
    public class OptionResult
    {
        public List<string> Expirations { get; set; }
        public YahooStockData StockData { get; set; }
        public List<OptionData> CallOptions { get; set; }
        public List<OptionData> PutOptions { get; set; }

    }
}
