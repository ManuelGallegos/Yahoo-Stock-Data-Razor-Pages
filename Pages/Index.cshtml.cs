using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Yahoo_Stock_Data_Razor_Pages.Models;

namespace Yahoo_Stock_Data_Razor_Pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public YahooStocks YahooModel { get; set; } = new YahooStocks();

        public async Task OnGet()
        {
            YahooModel.Ticker = "IBM";
            YahooModel.StartDate = DateTime.Parse("2020-10-01");
            YahooModel.EndDate = DateTime.Parse("2020-11-01");
            YahooModel.Period = "daily";
            var start = YahooModel.StartDate.ToString("yyyy-MM-dd");
            var end = YahooModel.EndDate.ToString("yyyy-MM-dd");
            YahooModel.StockData = await YahooClass.GetYahooStock(YahooModel.Ticker, start, end, YahooModel.Period);
        }

        public async Task OnPost()
        {
            var start = YahooModel.StartDate.ToString("yyyy-MM-dd");
            var end = YahooModel.EndDate.ToString("yyyy-MM-dd");
            YahooModel.StockData = await YahooClass.GetYahooStock(YahooModel.Ticker, start, end, YahooModel.Period);
        }

    }

    public class YahooStocks
    {
        public string Ticker { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Period { get; set; }
        public List<YahooStockData> StockData { get; set; }
    }

}
