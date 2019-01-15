using System.Windows.Forms;
using Avtec.DevMorningFix;

namespace DesktopApp
{
    internal class DesktopStartup : IStartup
    {
        private readonly Form1 _mainForm;

        public DesktopStartup(Form1 form1)
        {
            _mainForm = form1;
        }

        public void Start(params object[] parameters)
        {
            Application.EnableVisualStyles();
            Application.Run(_mainForm);
        }
    }
}