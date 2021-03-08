using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_1.Models.RequestModels
{
    class GET_Weather
    {
        
        public string appId { get; set; }
        public string mode { get; set; }
        public string q { get; set; }

        public string getQueryString()
        {
            return string.Format("?q={0}&appId={1}&mode={2}",q,appId,mode);
        }
    }
}
