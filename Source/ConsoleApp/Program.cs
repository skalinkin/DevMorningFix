using System;
using Avtec.DevMorningFix.ConsoleApp.Container;
using Avtec.DevMorningFix.ConsoleApp.Fundamentals;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var container = new SimpleIocContainer();
            //Bootstrapper.Configure(container);


            var fundamental1 = new Fundamental1();
            var fundamentaltwo = new FundamentalTwo();
            var fundamentalthree = new FundamentalThree();
            var fundamentalEight = new FundamentalEight();

            fundamental1.Print();
            Console.WriteLine($"2. {fundamentaltwo.Name}. {fundamentaltwo.Description}");
            Console.WriteLine($"3. {fundamentalthree.Name}. {fundamentalthree.Description}");
            Console.WriteLine("4. Extensibility.Extensibility means that you can enhance a system without causing violence to the underlying structure.You can change a piece of a system without affecting other pieces.The most likely changes cause the system the least trauma.");
            Console.WriteLine("5. Reusability.Reusability means designing the system so that you can reuse pieces of it in other systems.");
            Console.WriteLine("6. High fan-in.  High fan-in refers to having a high number of classes that use a given class. High fan-in implies that a system has been designed to make good use of utility classes at the lower levels in the system.");
            Console.WriteLine("7. Low-to-medium fan-out.  Low-to-medium fan-out means having a given class use a low-to-medium number of other classes.High fan-out (more than about seven) indicates that a class uses a large number of other classes and may therefore be overly complex.Researchers have found that the principle of low fan-out is beneficial whether you’re considering the number of routines called from within a routine or from within a class (Card and Glass 1990; Basili, Briand, and Melo 1996).");
            Console.WriteLine(fundamentalEight.Description);
            Console.WriteLine("9. Leanness.Leanness means designing the system so that it has no extra parts(Wirth 1995, McConnell 1997). Voltaire said that a book is finished not when nothing more can be added but when nothing more can be taken away.In software, this is especially true because extra code has to be developed, reviewed, tested, and considered when the other code is modified.Future versions of the software must remain backward compatible with the extra code.The fatal question is 'It’s easy, so what will we hurt by putting it in?'");
            Console.WriteLine("10. Stratification.Stratification means trying to keep the levels of decomposition stratified so that you can view the system at any single level and get a consistent view. Design the system so that you can view it at one level without dipping into other levels. For example, if you’re writing a modern system that has to use a lot of older, poorly designed code, write a layer of the new system that’s responsible for interfacing with the old code.Design the layer so that it hides the poor quality of the old code, presenting a consistent set of services to the newer layers.Then have the rest of the system use those classes rather than the old code.The beneficial effects of stratified design in such a case are(1) it compartmentalizes the messiness of the bad code and(2) if you’re ever allowed to jettison the old code or refactor it, you won’t need to modify any new code except the interface layer.");
            Console.WriteLine("11. Standard Techniques.The more a system relies on exotic pieces, the more intimidating it will be for someone trying to understand it the first time. Try to give the whole system a familiar feeling by using standardized, common approaches.");
            Console.ReadLine();
        }
    }
}