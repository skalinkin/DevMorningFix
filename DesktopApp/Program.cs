using System;
using System.Windows.Forms;
using Avtec.DevMorningFix.Infrastructure;
using Container;
using DesktopApp;

namespace Avtec.DevMorningFix.DesktopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            var container = GetContainer();
            var startup = container.Resolve<IStartup>();
            startup.Start();
        }

        private static IContainer GetContainer()
        {
            var container = new SimpleIocContainer();
            Register(container);
            Bootstrapper.Configure(container);
            return container;
        }

        private static void Register(SimpleIocContainer container)
        {
            container.Register<IStartup, DesktopStartup>();
            container.Register<Form1,Form1>();
        }
    }
}
