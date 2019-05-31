using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using fm.cred.front.mvc.Models;
using fm.cred.front.mvc.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace fm.cred.front.mvc.Controllers {
    public class HomeController : BaseController {
        private readonly IMockConfiguracaoGeralService _mockConfiguracaoGeralService;

        private readonly Func<string, IBaseService> _serviceAccessor;

        public HomeController (IMockConfiguracaoGeralService mockConfiguracaoGeralService,
            Func<string, IBaseService> serviceAccessor,
            IServiceProvider serviceProvider) : base (serviceProvider) {
            _mockConfiguracaoGeralService = mockConfiguracaoGeralService;
            _serviceAccessor = serviceAccessor;
        }

        public IActionResult Index () {
            var listMock = _mockConfiguracaoGeralService.Build ();

            // var soma1Service = this.GetType<IBaseService> (typeof (Soma1Service));
            //use serviceAccessor field to resolve desired type

            return View (listMock);
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}