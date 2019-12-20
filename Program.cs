using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            var kaynak = @"https://www.yeditepe.edu.tr/"; // URL YAZDIK
            HtmlWeb web = new HtmlWeb(); // Birtan Nesne oluşturduk
            var Rawresult = web.Load(kaynak); // nesnemizin load methoduna ulaşarak parametresine kaynak adlı urimizi verdik

            var Result = Rawresult.DocumentNode.SelectSingleNode("//head/title"); // istediğimiz html tagını belirttik

            Console.WriteLine(Result.OuterHtml); // ekrana basttık.
            Console.ReadLine();
        }
    }
}
