#pragma once
#include <string>
#include <map>
#include "IDependencyResolver.h"

class DependencyResolverFactory
{
public:
	static DependencyResolverFactory *GetInstance()
	{
		static DependencyResolverFactory instance;
		return &instance;
	}
	static std::unique_ptr<IDependencyResolver>CreateDependencyResolver(const std::string &resolverTypeName);
private:
	DependencyResolverFactory() = default;
	~DependencyResolverFactory() = default;
	DependencyResolverFactory(const DependencyResolverFactory &) = default;
	DependencyResolverFactory &operator=(const DependencyResolverFactory &) = default;
};
