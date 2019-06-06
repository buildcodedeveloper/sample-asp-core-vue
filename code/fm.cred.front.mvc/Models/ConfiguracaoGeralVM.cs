using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace fm.cred.front.mvc.Models {

    public class ConfiguracaoGeralVM {

        public ConfiguracaoGeralVM () {
            OptionConfig = new List<OptionConfig> ();
        }

        [JsonProperty ("cdevento")]
        public string CdEvento { get; set; }

        [JsonProperty ("formClass")]
        public string FormClass { get; set; }

        [JsonProperty ("cdsistema")]
        public string CdSistema { get; set; }

        [JsonProperty ("cdcampo")]
        public string CdCampo { get; set; }

        [JsonProperty ("cdtipocampo")]
        public string CdTipoCampo { get; set; }

        [JsonProperty ("nocampo")]
        public string NoCampo { get; set; }

        [JsonProperty ("options_config", ItemIsReference = true)]
        public IEnumerable<OptionConfig> OptionConfig { get; set; }

        [JsonProperty ("tipocampo")]
        public TipoCampoVM TipoCampo { get; set; }

        [JsonProperty ("dsdetalhescampo")]
        public DetalheCampoVM DsDetalhesCampo { get; set; }

        [JsonProperty ("vlordem")]
        public int VlOrdem { get; set; }

        [JsonProperty ("classcss")]
        public string Class_Css { get; set; }

        [JsonProperty ("flativo")]
        public bool FlAtivo { get; set; }

    }

}