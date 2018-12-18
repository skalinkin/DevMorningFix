using System;
using System.Windows.Forms;
using Avtec.DevMorningFix.BusinessTier;
using Avtec.DevMorningFix.FormatOutput;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private readonly SimpleManager _businessManager;
        private readonly IFundamentalFormat _format;
        private readonly IFundamentalModel _model;

        public Form1(SimpleManager businessManager, IFundamentalFormat format, IFundamentalModel model)
        {
            _businessManager = businessManager;
            _format = format;
            _model = model;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fundamentals = _businessManager.GetFundamentals();
            var format = _format.GetFormat();
            foreach (var fundamental in fundamentals)
            {
                var data = _model.GetData(fundamental);
                label1.Text += string.Format(format+"\n", data);
            }
        }
    }
}