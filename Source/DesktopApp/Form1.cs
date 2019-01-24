using System;
using System.Windows.Forms;
using Avtec.DevMorningFix.FormatOutput;
using Avtec.DevMorningFix.XmlStoreModule.DataManager;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private readonly IDataManager _dataManager;
        private readonly IFundamentalFormat _format;
        private readonly IFundamentalModel _model;

        /*
        Note: 
            This in no way suggests an implementation, solution or any other final construct.
            This is simply code put in to allow further refactoring towards improvement.
            I.e., it allows stuff to work for now.
        */
        public Form1(IDataManager dataManager, IFundamentalFormat format, IFundamentalModel model)
        {
            _dataManager = dataManager;
            _format = format;
            _model = model;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fundamentals = _dataManager.GetFundamentalsList();
            var format = _format.GetFormat();
            foreach (var fundamental in fundamentals)
            {
                var data = _model.GetData(fundamental);
                label1.Text += string.Format(format + "\n", data);
            }
        }
    }
}