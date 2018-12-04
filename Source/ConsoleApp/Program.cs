﻿using System;

namespace Avtec.DevMorningFix.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fundamentalEight = new FundamentalEight();
            Console.WriteLine("Hello World!");
            Console.WriteLine("1.Minimal complexity.The primary goal of design should be to minimize complexity for all the reasons just described(edit: What 'reasons just described' ? Read Chapter 5 of Code Complete 2, included below as an attachment to this Wiki Page!).Avoid making 'clever' designs.Clever designs are usually hard to understand.Instead make 'simple' and 'easy-to-understand' designs.If your design doesn't let you safely ignore most other parts of the program when you’re immersed in one specific part, the design isn't doing its job.");
            Console.WriteLine("2.Ease of maintenance.Ease of maintenance means designing for the maintenance programmer.Continually imagine the questions a maintenance programmer would ask about the code you’re writing.Think of the maintenance programmer as your audience, and then design the system to be self - explanatory.");
            Console.WriteLine("3.Loose coupling.Loose coupling means designing so that you hold connections among different parts of a program to a minimum.Use the principles of good abstractions in class interfaces, encapsulation, and information hiding to design classes with as few interconnections as possible.Minimal connectedness minimizes work during integration, testing, and maintenance.");
            Console.WriteLine("4. Extensibility.Extensibility means that you can enhance a system without causing violence to the underlying structure.You can change a piece of a system without affecting other pieces.The most likely changes cause the system the least trauma.");
            Console.WriteLine("5. Reusability.Reusability means designing the system so that you can reuse pieces of it in other systems.");
            Console.WriteLine("6. High fan-in.  High fan-in refers to having a high number of classes that use a given class. High fan-in implies that a system has been designed to make good use of utility classes at the lower levels in the system.");
            Console.WriteLine("7. Low-to-medium fan-out.  Low-to-medium fan-out means having a given class use a low-to-medium number of other classes.High fan-out (more than about seven) indicates that a class uses a large number of other classes and may therefore be overly complex.Researchers have found that the principle of low fan-out is beneficial whether you’re considering the number of routines called from within a routine or from within a class (Card and Glass 1990; Basili, Briand, and Melo 1996).");
            Console.WriteLine(fundamentalEight.Description);
            Console.WriteLine("9. Leanness.Leanness means designing the system so that it has no extra parts(Wirth 1995, McConnell 1997). Voltaire said that a book is finished not when nothing more can be added but when nothing more can be taken away.In software, this is especially true because extra code has to be developed, reviewed, tested, and considered when the other code is modified.Future versions of the software must remain backward compatible with the extra code.The fatal question is 'It’s easy, so what will we hurt by putting it in?'");
            Console.WriteLine("10. Stratification.Stratification means trying to keep the levels of decomposition stratified so that you can view the system at any single level and get a consistent view. Design the system so that you can view it at one level without dipping into other levels. For example, if you’re writing a modern system that has to use a lot of older, poorly designed code, write a layer of the new system that’s responsible for interfacing with the old code.Design the layer so that it hides the poor quality of the old code, presenting a consistent set of services to the newer layers.Then have the rest of the system use those classes rather than the old code.The beneficial effects of stratified design in such a case are(1) it compartmentalizes the messiness of the bad code and(2) if you’re ever allowed to jettison the old code or refactor it, you won’t need to modify any new code except the interface layer.");
            Console.WriteLine("11. Standard Techniques.The more a system relies on exotic pieces, the more intimidating it will be for someone trying to understand it the first time. Try to give the whole system a familiar feeling by using standardized, common approaches.");
        }
    }
}