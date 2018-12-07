using System;
using Avtec.DevMorningFix.AvtecEngineeringFundamentals;
using Avtec.DevMorningFix.ConsoleApp.Container;
using Avtec.DevMorningFix.Infrastructure;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new SimpleIocContainer();
            Bootstrapper.Configure(container);

            var fundamental1 = new Fundamental1();
            Fundamental fundamentalTwo = new FundamentalTwo();
            var fundamentalThree = new FundamentalThree();
            var fundamentalEight = new FundamentalEight();
            var fundamentalEleven = new FundamentalEleven();
            var fundamentalTen = new FundamentalTen();
            var fundamentalNine = new FundamentalNine();

            fundamental1.Print();
            Console.WriteLine($"2. {fundamentalTwo.Name}. {fundamentalTwo.Description}");
            Console.WriteLine($"3. {fundamentalThree.Name}. {fundamentalThree.Description}");
            Console.WriteLine( "4. Extensibility.Extensibility means that you can enhance a system without causing violence to the underlying structure.You can change a piece of a system without affecting other pieces.The most likely changes cause the system the least trauma.");
            Console.WriteLine( "5. Reusability.Reusability means designing the system so that you can reuse pieces of it in other systems.");
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