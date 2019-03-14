using System;
using Newtonsoft.Json.Linq;
using Postcodesio;
using RestSharp;

namespace Postcodeio
{
    public class SinglePostCodes
    {

        public RestClient Client { get; set; }

        public JObject PostcodeSingleResponseContent { get; set; }

        public string PostcodeSelected { get; set; }
        
        public SinglePostCodes() => Client = new RestClient
        {
            BaseUrl = new Uri(AppConfigReader.BaseUrl)
        };

        public void GetSinglePostCode(string postcode)
        {

            var request = new RestRequest();

            request.AddHeader("Content-Type", "application/json");

            PostcodeSelected = postcode;
            
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            IRestResponse response = Client.Execute(request);

            PostcodeSingleResponseContent = JObject.Parse(response.Content);

        }
    }
}
