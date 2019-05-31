using System.Collections.Generic;
using fm.cred.front.mvc.Models;

namespace fm.cred.front.mvc.Service {
    public interface IMockConfiguracaoGeralService {
        IEnumerable<ConfiguracaoGeralVM> Build ();
        IEnumerable<ConfiguracaoGeralVM> MockBuild ();
    }
}