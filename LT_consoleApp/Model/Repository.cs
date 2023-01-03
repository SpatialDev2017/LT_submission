
//using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LT_consoleApp.Model
{
    public class Repository
    {
       
        [JsonProperty(PropertyName = "albumId")]
        public int albumId { get; set; }

        [JsonProperty(PropertyName =  "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }
        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string thumbnailUrl { get; set; }
    }

}
