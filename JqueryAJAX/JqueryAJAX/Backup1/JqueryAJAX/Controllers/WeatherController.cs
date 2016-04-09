using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using JqueryAJAX.net.webservicex.www;
using System.Text;

namespace JqueryAJAX.Controllers
{
    public class WeatherController : Controller
    {
        //
        // GET: /Weather/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetWeather(string Id)
        {

            StringBuilder sb = new StringBuilder(); 
            WeatherForecast wf = new WeatherForecast();
            WeatherForecasts wfs = wf.GetWeatherByPlaceName(Id);
            WeatherData[] wd =   wfs.Details;

            sb.AppendFormat("<B>Weather Forecast for {0}</B><br /><br />", wfs.PlaceName);

            foreach (WeatherData d in wd)
            {
                if(!string.IsNullOrEmpty(d.WeatherImage))
                {
                    sb.AppendFormat("<img src=\"{0}\" >", d.WeatherImage);
                    sb.AppendFormat(" {0}", d.Day);
                    sb.AppendFormat(", High {0}F", d.MaxTemperatureF);
                    sb.AppendFormat(", Low {0}F<br />", d.MinTemperatureF);
                }
            }

            Response.Write(sb.ToString());
            return null; 
        }

    }
}
