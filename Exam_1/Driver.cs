using System;
using System.IO;
using System.Net.Http;
using System.Web;
using Exam_1.Models.JSONModels;
using Exam_1.Models.XMLModels;
using Exam_1.Models.RequestModels;


namespace Exam_1
{

    //API Key = 3901dadab60ac7e843958b159be48e34
    class Driver
    {

        static void Main(string[] args)
        {
            var weatherParameters = new GET_Weather()
            {
                appId = "3901dadab60ac7e843958b159be48e34",
                q = "New Delhi",
                mode = "xml"
            };
            string response = Rest.sendRequest(Rest.REQUEST.GET, "https://api.openweathermap.org/data/2.5/weather", weatherParameters);
            var jsonWeatherModel=J_WeatherModel.Deserialize(response);
            var xmlWeatherModel = X_WeatherModel.Deserialize(response);  
        }

    }
}
