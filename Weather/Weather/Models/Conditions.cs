using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;


namespace Weather.Models
{
    public class Conditions
    {

        string location = "No Data";
        string time = DateTime.Now.ToString();
        string wind = "No Data";
        string visibility = "No Data";
        string skyConditions = "No Data";
        string temperatureC = "No Data";
        string temperatureF = "No Data";
        string dewpoint = "No Data";
        string relativeHumidity = "No Data";
        string pressure = "No Data";

        public string Location
        {
            get { return location; }
            set { location = value; }

        }

        public string Time 
        { 
            get { return time; }
            set { time = value; }
        }


        public string Wind 
        { 
            get {return wind;}
            set {wind = value; }
        }


        public string Visibility 
        {
            get { return visibility; }
            set { visibility = value; }
        }


        public string SkyConditions 
        {
            get {return skyConditions ;}
            set { skyConditions = value; }
        }


        public string TemperatureC
        {
            get { return temperatureC; }
            set { temperatureC = value; }
        }


    }




} 