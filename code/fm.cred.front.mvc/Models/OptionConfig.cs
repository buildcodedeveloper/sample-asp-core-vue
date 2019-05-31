using Newtonsoft.Json;

namespace fm.cred.front.mvc.Models {
    public class OptionConfig {

        [JsonProperty ("id")]
        public string Id { get; set; }

        [JsonProperty ("cdconfigcampo")]
        public string CdConfigCampo { get; set; }

        [JsonProperty ("cdevento")]
        public string CdEvento { get; set; }

        [JsonProperty ("nome")]
        public string Nome { get; set; }

        [JsonProperty ("checked")]
        public bool Checked { get; set; }

        [JsonProperty ("order")]
        public string Order { get; set; }

        [JsonProperty ("flativo")]
        public bool Flativo { get; set; }

    }
}