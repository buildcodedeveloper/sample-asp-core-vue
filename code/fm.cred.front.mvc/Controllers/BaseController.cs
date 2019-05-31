using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using fm.cred.front.mvc.Helper;
using fm.cred.front.mvc.Models;
using fm.cred.front.mvc.Service;
using Microsoft.AspNetCore.Mvc;

namespace fm.cred.front.mvc.Controllers {
    public class BaseController : Controller {
        protected readonly IServiceProvider _serviceProvider;

        // private readonly IBaseService _baseService;

        public BaseController (IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }

        public T GetType<T> (Type type) {

            return (T) ServiceProviderServiceExtensions.GetRequiredService<T> (_serviceProvider, type);
        }

    }
}