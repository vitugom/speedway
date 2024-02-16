using Newtonsoft.Json;

namespace Projeto2023
{
    public class BuscaCep
    {
        [JsonProperty(PropertyName = "logradouro")]
        public string logradouro { get; set; }


        [JsonProperty(PropertyName = "bairro")]
        public string bairro { get; set; }


        [JsonProperty(PropertyName = "localidade")]
        public string cidade { get; set; }


        [JsonProperty(PropertyName = "uf")]
        public string estado { get; set; }

        [JsonProperty(PropertyName = "erro")]
        public string erro { get; set; }


    }
}
