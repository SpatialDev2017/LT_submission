using System;


namespace LT_consoleApp.Controller
{
    public class HttpClientRequestHandler : IRequestHandler
    {
       

        public string GetAlbumsById(string url, string id)
        {
           
            using (var httpClient = new HttpClient())
            {
                
                UriBuilder uri = new UriBuilder(url);
                string queryString = "albumId=" + id;
                if (uri.Query != null && uri.Query.Length > 1)
                {
                    uri.Query = uri.Query.Substring(1) + "&" + queryString;
                }
                else
                {
                    uri.Query = queryString;
                }

               // Console.WriteLine(uri.ToString());
                var response = httpClient.GetStringAsync(new Uri(uri.ToString())).Result;
                return response;
            }
        }

        public string GetPhotoById(string url, string id, string photoid)
        {
            using (var httpClient = new HttpClient())
            {
                // httpClient.BaseAddress = new Uri(url + id);

                var response = httpClient.GetStringAsync(new Uri(url + id+photoid)).Result;
                return response;
            }
        }
    }
}
