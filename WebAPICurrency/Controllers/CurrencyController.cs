using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPICurrency.Controllers
{
    public class CurrencyController : ApiController
    {
        [HttpGet]
        public decimal ConvertDanishKronerToEuro(decimal danishKroner)
        {
            return danishKroner / 745.99M * 100;
        }

        public decimal GetExchangeRate(string iso)
        {
            switch (iso)
            {
                case "USD":
                    return 524.02M;
                case "CAD":
                    return 492.27M;
                case "EUR":
                    return 745.99M;
                case "NOK":
                    return 90.34M;
                case "GBP":
                    return 947.53M;
                case "SEK":
                    return 78.21M;
                default:
                    return 0;
            }
        }
    }
}
