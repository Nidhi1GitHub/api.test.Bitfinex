using Api1.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BitfinexApiTest.Controllers
{
    public class ValuesController : ApiController
    {
        string Apikeystr = "kNpeMUgHtn4VZv2cqu18LGuBDflCC3zgks6O9GFBHRL";
        string Apikeysecret = "6xlqYzLfRoCTiS4WkWIIEY06lnEjPHjnqa0R66tavlN";

        [HttpGet]
        [Route("GetStatus")]
        public ApiResponse GetStatus()
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://api-pub.bitfinex.com/v2/platform/status");
            Request.Accept = "application/vnd.api+json";
            ApiResponse apiResponse = new ApiResponse();
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            StreamReader respStreamReader = new StreamReader(response.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            response.Close();
            apiResponse.Data = responseString;
            //ContinentsSingle Continent = JsonConvert.DeserializeObject<ContinentsSingle>(responseString);
            return apiResponse;
        }

        [HttpGet]
        [Route("GetAllTicker")]
        public ApiResponse GetAllTicker()
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://api-pub.bitfinex.com/v2/tickers?symbols=ALL");
            Request.Accept = "application/vnd.api+json";
            ApiResponse apiResponse = new ApiResponse();
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            StreamReader respStreamReader = new StreamReader(response.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            response.Close();
            apiResponse.Data = responseString;
            //ContinentsSingle Continent = JsonConvert.DeserializeObject<ContinentsSingle>(responseString);
            return apiResponse;
        }

        [HttpGet]
        [Route("GetTicker")]
        public ApiResponse GetTicker(string tickertype)
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://api-pub.bitfinex.com/v2/tickers?symbols=" + tickertype);
            Request.Accept = "application/vnd.api+json";
            ApiResponse apiResponse = new ApiResponse();
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            StreamReader respStreamReader = new StreamReader(response.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            response.Close();
            apiResponse.Data = responseString;
            return apiResponse;
        }

        [HttpGet]
        [Route("Ticker")]
        public ApiResponse Ticker()
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://api-pub.bitfinex.com/v2/ticker/tBTCUSD");
            Request.Accept = "application/vnd.api+json";
            ApiResponse apiResponse = new ApiResponse();
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            StreamReader respStreamReader = new StreamReader(response.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            response.Close();
            apiResponse.Data = respStreamReader.ReadToEnd();
            return apiResponse;
        }

        [HttpGet]
        [Route("GetTrade")]
        public ApiResponse GetTrade()
        {
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://api-pub.bitfinex.com/v2/platform/status");
            Request.Accept = "application/vnd.api+json";
            ApiResponse apiResponse = new ApiResponse();
            HttpWebResponse response = (HttpWebResponse)Request.GetResponse();
            StreamReader respStreamReader = new StreamReader(response.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            response.Close();
            //apiResponse.Data = responseString;
            //TradeData Continent = JsonConvert.DeserializeObject<TradeData>(responseString);
            var Continent = JObject.Parse(responseString);
            apiResponse.Data = Continent;
            return apiResponse;
        }
    }
}
