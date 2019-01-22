using System.Collections.Generic;
using Avtec.DevMorningFix;
using Avtec.NetCoreWebApp.Fundamentals;
using Microsoft.AspNetCore.Mvc;

namespace Avtec.NetCoreWebApp.Controllers
{
    public class FundamentalController : Controller
    {
        private readonly IFundamentalAccess _funAccess;

        public FundamentalController(IFundamentalAccess funAccess)
        {
            _funAccess = funAccess;
        }

        public IActionResult Index()
        {
            List<DevFixFundamental> viewModel = _funAccess.GetFundamentals();
            return View(viewModel);
        }
    }
}