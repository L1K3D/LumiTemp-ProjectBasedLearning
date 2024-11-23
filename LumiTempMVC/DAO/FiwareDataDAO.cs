using LumiTempMVC.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace LumiTempMVC.DAO
{
    public class FiwareDataDAO
    {

        private readonly HttpClient _httpClient;

        private const string IP_ADDRESS = "4.228.60.11";

        private const int PORT_STH = 8666;

        public FiwareDataDAO()
        {

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("fiware-service", "smart");
            _httpClient.DefaultRequestHeaders.Add("fiware-servicepath", "/");

        }

        public async Task<List<FiwareTemperatureDataViewModel>> GetTemperatureDataAsync(int lastN)
        {
            var url = $"http://{IP_ADDRESS}:{PORT_STH}/STH/v1/contextEntities/type/Temp/id/urn:ngsi-ld:Temp:04x/attributes/temperature?lastN={lastN}";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<RootObject>(content);

                if (data != null && data.ContextResponses != null)
                {
                    foreach (var contextResponse in data.ContextResponses)
                    {
                        if (contextResponse.ContextElement != null && contextResponse.ContextElement.Attributes != null)
                        {
                            foreach (var attribute in contextResponse.ContextElement.Attributes)
                            {
                                if (attribute.Values != null)
                                {
                                    return attribute.Values;
                                }
                            }
                        }
                    }
                }
            }

            return new List<FiwareTemperatureDataViewModel>();

        }

    }

    public class RootObject
    {
        public List<ContextResponse> ContextResponses { get; set; }
    }

    public class ContextResponse
    {
        public ContextElement ContextElement { get; set; }
    }

    public class ContextElement
    {
        public List<Attribute> Attributes { get; set; }
    }

    public class Attribute
    {
        public List<FiwareTemperatureDataViewModel> Values { get; set; }
    }

}
