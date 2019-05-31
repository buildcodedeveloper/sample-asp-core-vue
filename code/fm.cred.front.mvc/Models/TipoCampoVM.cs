using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace fm.cred.front.mvc.Models {
    public class TipoCampoVM {

        [JsonProperty ("cdsistema")]
        public string CdSistema { get; set; }

        [JsonProperty ("cdtipocampo")]
        public string CdTipoCampo { get; set; }

        [JsonProperty ("dstipocampo")]
        public string DsTipoCampo { get; set; }

        [JsonProperty ("noexibicao")]
        public string NoExibicao { get; set; }

        [JsonProperty ("dstiponatabela")]
        public string DsTipoNaTabela { get; set; }

        [JsonProperty ("tipocampohtml")]
        public TipoCampoHtml TipoCampoHtml { get; set; }
        public string VlTamanhoNaTabela { get; set; }

        
        public bool FlAtivo { get; set; }
    }

    public enum TipoCampoHtml {
        TEXT = 0,
        RADIO = 1,
        CHECKBOX = 2,
        DATETIME = 3,
        NUMBER = 4,
        SELECT = 5,
        EMAIL = 6,
        HIDDEN = 7,
        TEL = 8,
        PASSWORD = 9,
        DATE = 10,
        TIME = 11,
        URL = 12,

    }
}