using System;
using System.Collections.Generic;
using System.Web.UI;
using Avtec.DevMorningFix.Container;

namespace Avtec.DevMorningFix.WebApp
{
    public partial class _Default : Page
    {
        private readonly IOutput _output;
        private readonly IFundamentalRepository _repository;
        private IEnumerable<IDevFixFundamental> fundamentals;

        protected void Page_Load(object sender, EventArgs e)
        {
            Bootstrapper.Instance.Configure();
            var instanceDependencyResolver = Bootstrapper.Instance.DependencyResolver;
            var compositionRoot = instanceDependencyResolver.GetService<IStartup>();
            var final = string.Empty;
            TextBox_Fundamentals.Text = final;
        }
    }
}