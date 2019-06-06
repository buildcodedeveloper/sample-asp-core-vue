using System.Collections.Generic;
using Newtonsoft.Json;

namespace fm.cred.front.mvc.Models {
    public class DetalheCampoVM {

        [JsonProperty ("alvoPesqAmpl")]
        public bool AlvoPesqAmpl { get; set; }

        [JsonProperty ("alvoPesqExata")]
        public bool AlvoPesqExata { get; set; }

        [JsonProperty ("nomeCampo")]
        public string NomeCampo { get; set; }

        [JsonProperty ("nomeCampoBancoDados")]
        public string NomeCampoBancoDados { get; set; }

        [JsonProperty ("nomeCampoLabel")]
        public string NomeCampoLabel { get; set; }

        [JsonProperty ("obrigatorio")]
        public bool Obrigatorio { get; set; }

        [JsonProperty ("obrigatorioMensagem")]
        public string ObrigatorioMensagem { get; set; }

        [JsonProperty ("QtdCaracteres")]
        public int qtdCaracteres { get; set; }

        [JsonProperty ("tabOrdem")]
        public int TabOrdem { get; set; }

        [JsonProperty ("tamCompr")]
        public int TamCompr { get; set; }

        [JsonProperty ("numeric")]
        public bool Numeric { get; set; }

        [JsonProperty ("tipoCamp")]
        public string TipoCamp { get; set; }

        [JsonProperty ("listavaores")]
        public List<string> Listavaores { get; set; }

        [JsonProperty ("mascara")]
        public string mascara { get; set; }

        [JsonProperty ("validar")]
        public bool Validar { get; set; }

        [JsonProperty ("autoCarregar")]
        public bool AutoCarregar { get; set; }

        [JsonProperty ("nomeCampoColuna")]
        public int NomeCampoColuna { get; set; }

        [JsonProperty ("nomeLabelCampoColuna")]
        public int NomeLabelCampoColuna { get; set; }

        [JsonProperty ("subirLinha")]
        public bool SubirLinha { get; set; }

        [JsonProperty ("tamAltura")]
        public int TamAltura { get; set; }

        [JsonProperty ("maiuscMinusc")]
        public string MaiuscMinusc { get; set; }

        [JsonProperty ("visivelWinForm")]
        public bool VisivelWinForm { get; set; }

        [JsonProperty ("visivelWebForm")]
        public bool VisivelWebForm { get; set; }

        [JsonProperty ("habilitadoWinForm")]
        public bool HabilitadoWinForm { get; set; }

        [JsonProperty ("habilitadoWebForm")]
        public bool HabilitadoWebForm { get; set; }

        [JsonProperty ("somenteLeituraWinForm")]
        public bool SomenteLeituraWinForm { get; set; }

        [JsonProperty ("somenteLeituraWebForm")]
        public bool SomenteLeituraWebForm { get; set; }

        [JsonProperty ("marcado")]
        public bool Marcado { get; set; }

        [JsonProperty ("executarAcaoAoSair")]
        public bool ExecutarAcaoAoSair { get; set; }

        [JsonProperty ("nomeClasseCSS")]
        public string NomeClasseCSS { get; set; }
    }

}