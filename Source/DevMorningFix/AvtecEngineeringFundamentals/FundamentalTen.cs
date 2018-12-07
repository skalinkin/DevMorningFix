namespace Avtec.DevMorningFix.AvtecEngineeringFundamentals
{
    public class FundamentalTen
    {
        public string Description = "10. Stratification.Stratification means trying to keep the levels of decomposition stratified so that you can view the system at any single level and get a consistent view. Design the system so that you can view it at one level without dipping into other levels. For example, if you’re writing a modern system that has to use a lot of older, poorly designed code, write a layer of the new system that’s responsible for interfacing with the old code.Design the layer so that it hides the poor quality of the old code, presenting a consistent set of services to the newer layers.Then have the rest of the system use those classes rather than the old code.The beneficial effects of stratified design in such a case are(1) it compartmentalizes the messiness of the bad code and(2) if you’re ever allowed to jettison the old code or refactor it, you won’t need to modify any new code except the interface layer.";
    }
}