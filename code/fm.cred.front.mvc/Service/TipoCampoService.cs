using System;
using Bogus;
using fm.cred.front.mvc.Models;

namespace fm.cred.front.mvc.Service {
    public class TipoCampoService : IMockTipoCampoService {
        public TipoCampoVM Build () {

            var testTipoCampo = new Faker<TipoCampoVM> ("pt_BR")
                .RuleFor (o => o.CdTipoCampo, f => Guid.NewGuid ().ToString ())
                .RuleFor (o => o.DsTipoCampo, f => f.Company.CompanyName ())
                .RuleFor (o => o.DsTipoNaTabela, f => $"campo_{Guid.NewGuid ().ToString ().Substring (0, 6)}")
                .RuleFor (o => o.TipoCampoHtml, f => f.PickRandom<TipoCampoHtml> ())
                .RuleFor (o => o.CdSistema, f => Guid.NewGuid ().ToString ().Substring (0, 6))
                .RuleFor (o => o.FlAtivo, f => f.Random.Bool ())
                .RuleFor (o => o.NoExibicao, f => $"Campo {Guid.NewGuid ().ToString ().Substring (0, 6)}")
                .RuleFor (o => o.VlTamanhoNaTabela, f => Guid.NewGuid ().ToString ().Substring (0, 6));

            return testTipoCampo;
        }
    }
}