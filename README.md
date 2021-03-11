# Exams

## Dependencies 

1. Newtonsoft.Json ( Download using NuGet) : It is a very widely used JSON Parsing library.

## How to Run 

1. Clone the Repository 
2. Open Exam_1.sln and simply build the project.


## Getting API result in JSON or XML.

 ```
 var weatherParameters = new GET_Weather()
            {
                appId = "3901dadab60ac7e843958b159be48e34",
                q = "New Delhi",
                mode = "xml"
            };
 ```

Replace "xml" to "json" for Json Result and Vice Versa
