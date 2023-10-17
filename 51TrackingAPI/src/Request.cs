using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tracking51API.Util;

namespace Tracking51API;

public class Request
{

    private readonly HttpClient _httpClient;

    private readonly string _apiVersion = "v4";

    private readonly string _apiBaseUrl = "api.51Tracking.com";

    private readonly int _apiPort = 443;

    private readonly int _timeout = 10;

    private Dictionary<string, string> _headers;

    private string _apiKye = "";

    private string _url = "";

    public string getRequestUrl(string path = ""){
        string pact = (_apiPort == 443) ? "https" : "http"; 
        string url = pact + "://" + _apiBaseUrl + "/" + _apiVersion + "/" + path;
        return url;
    }

    private Dictionary<string, string> getHeaders(){
        Dictionary<string, string> headers = new Dictionary<string, string>
        {
            { "Accept", "application/json" },
            { "Tracking-Api-Key", _apiKye}
        };
        return headers;
    }

    public Request()
    {

        _apiKye = Tracking51.apiKey;

        _httpClient = new HttpClient();

    }

    public string MakeRequest(string path, HttpMethod method, object requestData = null)
    {
        _url = getRequestUrl(path);

        _headers = getHeaders();

        var request = new HttpRequestMessage(method, _url);
        
        if (_headers != null)
        {
            foreach (var header in _headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }
        }

        if (requestData != null)
        {
            if (method == HttpMethod.Get){
                string queryString = StringUtil.ObjectToQueryString(requestData);
                _url = _url + "?" + queryString;
                request.RequestUri = new Uri(_url);
            }else{
                string jsonData = JsonConvert.SerializeObject(requestData, Formatting.Indented, new JsonSerializerSettings {
                    NullValueHandling = NullValueHandling.Ignore
                });
                var jsonContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                request.Content = jsonContent;
            }
        }

        _httpClient.Timeout = TimeSpan.FromSeconds(_timeout);

        ServicePointManager.ServerCertificateValidationCallback =
        (sender, certificate, chain, sslPolicyErrors) => true;

        var response = _httpClient.SendAsync(request).Result;

        return response.Content.ReadAsStringAsync().Result;
    }

}
