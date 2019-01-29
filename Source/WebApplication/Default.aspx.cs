using System;
using System.Collections.Generic;
using System.Web.UI;
using Avtec.DevMorningFix.BusinessCases;
using Avtec.DevMorningFix.Container;



namespace Avtec.DevMorningFix.WebApp
{
    public partial class _Default : Page
    {
        private readonly IOutput _output;
        private IEnumerable<IDevFixFundamental> fundamentals;
        //private readonly IFundamentalRepository _repository;

        //private readonly IFundamentalRepository _repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bootstrapper.Instance.Configure();
            var instanceDependencyResolver = Bootstrapper.Instance.DependencyResolver;
            //var compositionRoot = instanceDependencyResolver.GetCompositionRoot();
            string final = string.Empty;
            TextBox_Fundamentals.Text = final;

        }

    }
}