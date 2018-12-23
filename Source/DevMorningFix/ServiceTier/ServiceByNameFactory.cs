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