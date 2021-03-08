using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Exam_1.Models.RequestModels;

namespace Exam_1
{
    class Rest
    {
        public enum Mode
        {
            JSON=1,
            XML=2
        }
        public enum REQUEST
        {
            GET=1,
            POST=2
        }

        public static string sendRequest(REQUEST request,string url,GET_Weather parameters)
        {
            string responseString = string.Empty; 
            if(request==REQUEST.GET)
            {
                
                  
                var client = (HttpWebRequest)WebRequest.Create(url+parameters.getQueryString());
                client.Method = request.ToString();
                client.ContentLength = 0;
                var response = (HttpWebResponse)client.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                    return String.Format("Request Failed, HTTP Status Code : {0}", response.StatusCode);

                var responseStream = response.GetResponseStream();
                if (responseStream != null)
                {
                    var streamReader = new StreamReader(responseStream);
                    responseString = streamReader.ReadToEnd();
                }
            }
            return responseString;
        }

       
        
    }
}
