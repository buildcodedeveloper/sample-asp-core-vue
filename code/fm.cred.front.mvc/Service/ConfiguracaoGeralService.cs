using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bogus;
using fm.cred.front.mvc.Helper;
using fm.cred.front.mvc.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace fm.cred.front.mvc.Service {
    public class ConfiguracaoGeralService : IMockConfiguracaoGeralService {
        public const string CultureSettings = "pt-BR";

        private List<ConfiguracaoGeralVM> ConfiguracaoGeralVMList = new List<ConfiguracaoGeralVM> ();
        private List<TipoCampoVM> TipoCampoVMList = new List<TipoCampoVM> ();
        private readonly IHostingEnvironment _env;

        public string LangRouteController { get; set; }

        public ConfiguracaoGeralService (IHostingEnvironment env) => _env = env;
        public IEnumerable<ConfiguracaoGeralVM> Build () {

            try {
                // var optionsConfig = File.ReadAllText ($@"{_env.ContentRootPath}\Json\option.json");

                // var tipo_campoConfig = File.ReadAllText ($@"{_env.ContentRootPath}\Json\tipo_campo.json");

                var config_campoConfig = File.ReadAllText ($@"{_env.ContentRootPath}\Json\config_campo.json");
                var languageConfig = File.ReadAllText ($@"{_env.ContentRootPath}\Json\language.json");

                // var optionConfigVMList = JsonConvert.DeserializeObject<List<OptionConfig>> (optionsConfig);
                var configuracaoGeralVMList = JsonConvert.DeserializeObject<List<ConfiguracaoGeralVM>> (config_campoConfig);
                var languageVMList = JsonConvert.DeserializeObject<List<LanguageVM>> (languageConfig);

                // var tipoCampoVMList = JsonConvert.DeserializeObject<List<TipoCampoVM>> (tipo_campoConfig);

                foreach (var configCampo in configuracaoGeralVMList) {

                    string campoNome = configCampo.DsDetalhesCampo?.NomeCampo;

                    var resultLang = languageVMList.FirstOrDefault (l => l.Cultura.Equals (LangRouteController) &&
                        l.AmbienteOption == AmbienteOption.FRONT &&
                        l.CdEvento.Equals ("000101") &&
                        l.Chave.ToLower ().Equals (campoNome?.ToLower ()));

                    if (resultLang != null)
                        configCampo.DsDetalhesCampo.NomeCampoLabel = resultLang.Valor;;
                }

                // var configuracaoGeralVM = new ConfiguracaoGeralVM {
                //     CdEvento = "000101",
                //     CdCampo = Guid.NewGuid ().ToString ().Substring (0, 6),
                //     NoCampo = "Nome",
                //     FlAtivo = true,
                // };

                // configuracaoGeralVM = new ConfiguracaoGeralVM {
                //     CdEvento = "000101",
                //     CdCampo = Guid.NewGuid ().ToString ().Substring (0, 6),
                //     NoCampo = "CPF",
                //     FlAtivo = true,
                // };

                // configuracaoGeralVM.VlOrdem = GetOrderCampo (ConfiguracaoGeralVMList);

                // ConfiguracaoGeralVMList.Add (configuracaoGeralVM);

                // configuracaoGeralVM = new ConfiguracaoGeralVM {
                //     CdEvento = "000101",
                //     CdCampo = Guid.NewGuid ().ToString ().Substring (0, 6),
                //     NoCampo = "Categorias",
                //     FlAtivo = true,
                // };

                // configuracaoGeralVM.VlOrdem = GetOrderCampo (ConfiguracaoGeralVMList);

                // ConfiguracaoGeralVMList.Add (configuracaoGeralVM);

                return configuracaoGeralVMList;
            } catch (Exception ex) {

                Console.WriteLine (ex.Message);
            }

            return null;
        }

        private void GetSelectOption (List<OptionConfig> optionConfigVMList, ConfiguracaoGeralVM configCampo) {
            configCampo.OptionConfig = optionConfigVMList.Where (o => o.CdConfigCampo.Equals (configCampo.CdCampo));

        }

        private int GetOrderCampo (List<ConfiguracaoGeralVM> configuracaoGeralVMList) {
            var order = RandomExtensions.RandomNumber (1, 11);

            if (configuracaoGeralVMList.Any (x => x.VlOrdem.Equals (order)))
                return GetOrderCampo (ConfiguracaoGeralVMList);

            return order;
        }

        public IEnumerable<ConfiguracaoGeralVM> MockBuild () {
            var classCssRandom = new [] { "col-md-6", "col-md-4", "col-md-7", "col-md-8", "col-md-10" };

            var testTipoCampo = new Faker<TipoCampoVM> ("pt_BR")
                .RuleFor (o => o.CdTipoCampo, f => Guid.NewGuid ().ToString ())
                .RuleFor (o => o.DsTipoCampo, f => f.Company.CompanyName ())
                .RuleFor (o => o.DsTipoNaTabela, f => $"campo_{Guid.NewGuid ().ToString ().Substring (0, 6)}")
                .RuleFor (o => o.TipoCampoHtml, f => f.PickRandom<TipoCampoHtml> ())
                .RuleFor (o => o.CdSistema, f => Guid.NewGuid ().ToString ().Substring (0, 6))
                .RuleFor (o => o.FlAtivo, f => f.Random.Bool ())
                .RuleFor (o => o.NoExibicao, f => $"Campo {Guid.NewGuid ().ToString ().Substring (0, 6)}")

                .RuleFor (o => o.VlTamanhoNaTabela, f => Guid.NewGuid ().ToString ().Substring (0, 6));

            var testConfiguracaoGeral = new Faker<ConfiguracaoGeralVM> ()
                .RuleFor (o => o.CdCampo, f => Guid.NewGuid ().ToString ().Substring (0, 6))
                .RuleFor (o => o.CdEvento, f => "000101")
                //Pick some fruit from a basket
                .RuleFor (o => o.TipoCampo, f => testTipoCampo)
                .RuleFor (o => o.FlAtivo, f => f.Random.Bool ())
                // .RuleFor (o => o.DsDetalhesCampo, f => f.Company.CompanySuffix ())
                //A random quantity from 1 to 10
                .RuleFor (o => o.VlOrdem, f => f.Random.Number (1, 10));

            return testConfiguracaoGeral.Generate (10);
        }
    }
}