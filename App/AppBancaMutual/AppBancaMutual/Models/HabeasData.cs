using Newtonsoft.Json;

namespace AppBancaMutual.Models
{
    public class HabeasData
    {
        [JsonProperty(PropertyName = "IdHabeasData")]
        public string IdHabeasData { get; set; }
        [JsonProperty(PropertyName = "DocumentoHabeasData")]
        public string DocumentoHabeasData { get; set; }
    }
}
