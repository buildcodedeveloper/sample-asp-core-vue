using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using fm.cred.front.mvc.Context;
using fm.cred.front.mvc.Models;
using fm.cred.front.mvc.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace fm.cred.front.mvc.Controllers {
    public class HomeController : BaseController {
        private readonly IMockConfiguracaoGeralService _mockConfiguracaoGeralService;

        private readonly Func<string, IBaseService> _serviceAccessor;
        private readonly DataContext _dataContext;

        public HomeController (IMockConfiguracaoGeralService mockConfiguracaoGeralService,
            Func<string, IBaseService> serviceAccessor,
            IServiceProvider serviceProvider,
            DataContext dataContext) : base (serviceProvider) {
            _mockConfiguracaoGeralService = mockConfiguracaoGeralService;
            _serviceAccessor = serviceAccessor;
            _dataContext = dataContext;
        }

        public IActionResult Index () {

            _mockConfiguracaoGeralService.LangRouteController = "en-US";
            var listMock = _mockConfiguracaoGeralService.Build ();

            return View (listMock);
        }

        public IActionResult Privacy () {
            return View ();
        }

        [HttpPost ("salvar")]
        public IActionResult Created () {
            return Ok (new { success = true });
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}