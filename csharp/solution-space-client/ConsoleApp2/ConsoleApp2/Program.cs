// See https://aka.ms/new-console-template for more information
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Text;

Console.WriteLine("Hello, World!");

string jsonString = @"{
    'productId': 'TEMP_SYN_1',
    'language': 'system',
    'variableIds': ['SPEC_TYPE','415','424','LEVEL_0'],
    'assignments': [
        {  
            'variableId': 'MFG_SITE',
            'type': 'AllowedValues',
            'allowedValues': [
                {  
                    'type': 'SingletonValue',
                    'value': '1102'
                 }
            ],
            'priority': 0,
            'exclude': true
        }
        ]
    }";
TableRequest tableRequest = JsonConvert.DeserializeObject<TableRequest>(jsonString)!;

Console.WriteLine("String Request Data " + tableRequest.ToString());

ApiClient apiclient =new ApiClient("https://syngenta.demo.configit.cloud:9001/solution-space/v1");
apiclient.AddDefaultHeader("Authorization", "ApiKey ZmE4ZDkwMmQ2MTllNGY2NGE1MmYxMGM2ZmQzYjkwMzNfMTgzMmJlZDIwOWE1NGJkZWFlMDM0MWMwYjg5Njg0OTk=");
apiclient.AddDefaultHeader("Content-Type", "application/json");

TableApi tableApi = new TableApi(apiclient);
var tableResoponse = tableApi.GetTable(tableRequest, "chn1/rel1~cb6737cd-0b82-4db0-825a-d116ecbaea02",0,100);

Console.WriteLine(tableResoponse);
