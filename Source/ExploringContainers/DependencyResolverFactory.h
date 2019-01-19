#pragma once
#include <string>
#include <map>
#include "IDependencyResolver.h"
#include <boost/property_tree/ptree_fwd.hpp>

class DependencyResolverFactory
{
public:
	DependencyResolverFactory();
	~DependencyResolverFactory() = default;
	DependencyResolverFactory(const DependencyResolverFactory &) = default;
	DependencyResolverFactory &operator=(const DependencyResolverFactory &) = default;

	std::string GetContainerName() const;
	std::unique_ptr<IDependencyResolver>CreateDependencyResolver() const;

private:
	static std::string m_sFilePath;
	static std::shared_ptr<boost::property_tree::ptree> m_pInputXMLTree;
};
