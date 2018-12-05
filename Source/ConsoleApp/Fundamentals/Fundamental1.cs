using System;

namespace Avtec.DevMorningFix.ConsoleApp.Fundamentals
{

    public class Fundamental1
    {
        public void Print()
        {
            var currFundamental = Create();
            Console.WriteLine($"{currFundamental.Name} {currFundamental.Description}");
        }

        private Fundamental Create()
        {
            Fundamental funDa = new Fundamental
            {
                Name = GetDescription(),
                Description = GetName()
            };
            return funDa;
        }

        private string GetName()
        {
            return "The primary goal of design should be to minimize complexity for all the reasons just described(edit: What 'reasons just described' ? Read Chapter 5 of Code Complete 2, included below as an attachment to this Wiki Page!).Avoid making 'clever' designs.Clever designs are usually hard to understand.Instead make 'simple' and 'easy-to-understand' designs.If your design doesn't let you safely ignore most other parts of the program when you’re immersed in one specific part, the design isn't doing its job.";
        }

        private string GetDescription()
        {
            return "1. Minimal complexity.";
        }
    }
}
