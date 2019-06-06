using Newtonsoft.Json;

namespace fm.cred.front.mvc.Models {
    public class LanguageVM {

        [JsonProperty ("id")]
        public string Id { get; set; }

        [JsonProperty ("cdEvento")]
        public string CdEvento { get; set; }

        [JsonProperty ("chave")]
        public string Chave { get; set; }

        [JsonProperty ("valor")]
        public string Valor { get; set; }

        [JsonProperty ("cultura")]
        public string Cultura { get; set; }

        [JsonProperty ("ambienteOption")]
        public AmbienteOption AmbienteOption { get; set; }

        [JsonProperty ("desativado")]
        public bool Desativado { get; set; }

    }

    public enum AmbienteOption {
        FRONT = 0,
        BACK = 1
    }
}