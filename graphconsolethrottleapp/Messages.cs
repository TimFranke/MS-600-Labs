using Newtonsoft.Json;
using System;
namespace graphconsolethrottleapp
{
    public class Messages
    {
        [JsonProperty(PropertyName = "@odata.context")]
        public string ODataContext { get; set; }
        [JsonProperty(PropertyName = "@odata.nextLink")]
        public string ODataNextLink { get; set; }
        [JsonProperty(PropertyName = "value")]
        public Message1[] Items { get; set; }
    }
    public class Message1
    {
        [JsonProperty(PropertyName = "@odata.etag")]
        public string ETag { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }
    }
}