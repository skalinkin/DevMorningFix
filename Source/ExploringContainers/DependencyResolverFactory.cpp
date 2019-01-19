#include "pch.h"
#include "DependencyResolverFactory.h"
#include "IDependencyResolver.h"
#include "HypodermicAdapter.h"
#include "BoostDIAdapter.h"

using namespace std;

std::unique_ptr<IDependencyResolver> DependencyResolverFactory::CreateDependencyResolver(const string & resolverTypeName)
{
	// TODO: this need to be some form of map lookup
	// 
	unique_ptr<IDependencyResolver> upDr;
	int nCmp = -1;

	if ((nCmp = resolverTypeName.compare("hypodermic")) == 0)
	{
		upDr.reset(new HypodermicAdapter());
	}
	else if ((nCmp = resolverTypeName.compare("boostdi")) == 0)
	{
		upDr.reset(new BoostDIAdapter());
	}
	return upDr;
}
