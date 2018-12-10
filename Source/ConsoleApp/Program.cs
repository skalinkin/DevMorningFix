using System;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ConsoleApp.Container;
using Avtec.DevMorningFix.DataManager;
using Avtec.DevMorningFix.Infrastructure;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new SimpleIocContainer();
            Bootstrapper.Configure(container);
            IDataManager dataManager = new XmlManager();

            var fundamental1 = new Fundamental1();
            Fundamental fundamentalTwo = new FundamentalTwo();
            var fundamentalThree = new FundamentalThree();
            var fundamentalEight = new FundamentalEight();
            var fundamentalEleven = new FundamentalEleven();
            var fundamentalTen = new FundamentalTen();
            var fundamentalNine = new FundamentalNine();
            // maybe they could all be built similarly
            // all deriving from IDevFixFundamental
            // maybe wouldn't need 11 classes
            // stick them in a list - roll through and print (for this ecercise)
            // maybe I should just get the values (name, description) and simply pass them in ??
            var fundamentalFive = new DevFixFundamental("5", dataManager);
            // or just get the whole she-bang
            // IEnumerable<IDevFixFundamental> objList = dataManager.GetFundamentalsList();
            //
            fundamental1.Print();
            Console.WriteLine($"2. {fundamentalTwo.Name}. {fundamentalTwo.Description}");
            Console.WriteLine($"3. {fundamentalThree.Name}. {fundamentalThree.Description}");
            Console.WriteLine( "4. Extensibility.Extensibility means that you can enhance a system without causing violence to the underlying structure.You can change a piece of a system without affecting other pieces.The most likely changes cause the system the least trauma.");

            Console.WriteLine(fundamentalFive.ToString());
            Console.WriteLine(new FundamentalSix().ToString());
            Console.WriteLine(new FundamentalSeven().Description);
            Console.WriteLine(fundamentalEight.Description);
            Console.WriteLine(fundamentalNine.Description);
            Console.WriteLine(fundamentalTen.Description);
            Console.WriteLine(fundamentalEleven.Description);
            Console.ReadLine();
        }
    }
}