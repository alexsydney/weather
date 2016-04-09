using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;


namespace Weather.Models
{
    public class Weather
    {

        public static Conditions GetCurrentConditions(string location) 
        {
            Conditions conditions = new Conditions();
            XmlDocument xmlConditions = new XmlDocument();

            xmlConditions.Load(string.Format("http://www.google.com/ig/api?weather={0}", location));

             if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
            {
                conditions = null;
            }
            else
             {

                conditions.Location = xmlConditions.SelectSingleNode("/xml_api_reply/weather/forecast_information/location").Attributes["data"].InnerText;
                conditions.Time = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/time").Attributes["data"].InnerText;
                conditions.Wind = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/wind").Attributes["data"].InnerText;
                conditions.Visibility = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/visibility").Attributes["data"].InnerText;
                conditions.SkyConditions = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/sky_condition").Attributes["data"].InnerText;
                conditions.TemperatureC = xmlConditions.SelectSingleNode("/xml_api_reply/weather/current_conditions/temp_c").Attributes["data"].InnerText;

             }


            return conditions;
        }



        public static List<Conditions> GetForecast(string location)
        {
            List<Conditions> conditions = new List<Conditions>();
            XmlDocument xmlConditions = new XmlDocument();
            xmlConditions.Load(string.Format("http://www.google.com/ig/api?weather={0}", location));
            if (xmlConditions.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
            {
                conditions = null;

            }
            else
            {
                foreach (XmlNode node in xmlConditions.SelectNodes("/xml_api_reply/weather/forecast_conditions"))
                {
                    Conditions condition = new Conditions();
                    condition.Location = xmlConditions.SelectSingleNode("/xml_api_reply/weather/forecast_information/location").Attributes["data"].InnerText;
                    condition.SkyConditions = node.SelectSingleNode("sky_condition").Attributes["data"].InnerText;
                    condition.Wind = node.SelectSingleNode("wind").Attributes["data"].InnerText;
                    condition.TemperatureC = node.SelectSingleNode("tempC").Attributes["data"].InnerText;
                }
            }
                return conditions;
         
        }





    }
}