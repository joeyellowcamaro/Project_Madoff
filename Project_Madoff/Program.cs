using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSQ.core.Quotes;

namespace Project_Madoff
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());


            /* 
            * 
            var quote_service = new QuoteService();

            var quotes = quote_service.Quote("MSFT", "GOOG").Return(QuoteReturnParameter.Symbol,
                                                                    QuoteReturnParameter.Name,
                                                                    QuoteReturnParameter.Open);


            //Get info from the quotes
            foreach (var quote in quotes)
            {
                Console.WriteLine("{0} - {1} - {2}", quote.Symbol, quote.Name, quote.Open);
            }

            */

        }
    }
}
