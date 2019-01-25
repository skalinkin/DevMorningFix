#pragma once
#include <string>
#include "IDependencyResolver.h"
#include <boost/property_tree/ptree_fwd.hpp>

constexpr auto CONTAINERNAME_HYPODERMIC = "hypodermic";
constexpr auto CONTAINERNAME_BOOSTDI = "boostdi";

class DependencyResolverFactory
{
public:
	DependencyResolverFactory();
	~DependencyResolverFactory() = default;
	DependencyResolverFactory(const DependencyResolverFactory &) = default;
	DependencyResolverFactory &operator=(const DependencyResolverFactory &) = default;
	std::unique_ptr<IDependencyResolver>CreateDependencyResolver() const;

private:
	std::string GetContainerName() const;
	std::string ContainerNameToLower(std::string) const;
	static std::string m_sFilePath;
	static std::shared_ptr<boost::property_tree::ptree> m_pInputXMLTree;

};
