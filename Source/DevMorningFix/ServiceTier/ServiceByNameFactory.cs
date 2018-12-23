using System;
using System.Configuration;
using Avtec.DevMorningFix.ServiceTier.DataManager;
using DevMorningFix.services.Exceptions;

namespace Avtec.DevMorningFix.ServiceTier
{
    public class ServiceByNameFactory
    {
        private static ISimpleFundamentalService _service;
        private static IDataManager _dataManager;

        /*

         todo this is a giant step backwards from the prior iteration
         todo this loses the ability to provide the business manager with multiple service support
         todo and is a move away from the separated interface pattern and the plugin pattern
         todo but you containerized it - over did it. But not by too much.
         todo so back this off to take a name and return a service
         todo   so a client would say IXyx xyzSvc = (IXyz) factory.GetService(typeof(IXyz).Name);
         todo   or something like that. The business manager is the client here.
         todo   I don't think the businessManager knows how/why to make/use more than one service
         todo Same goes for the IDataManager ?
         todo Maybe the data manager stays the way it is. Would you mix xml and db access ?
         todo I short, both (maybe not IDataManager) need to be decoupled aka dynamically loaded

         todo interesting goof up

        */
        public ServiceByNameFactory(ISimpleFundamentalService service, IDataManager dataManager)
        {
            _dataManager = dataManager;
            _service = service;
        }

        public ISimpleService GetService()
        {
            var objType = _service.GetType();
            object obj = Activator.CreateInstance(objType, _dataManager);

            return (ISimpleFundamentalService) obj;
        }
    }
}