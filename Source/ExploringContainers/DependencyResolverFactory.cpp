#include "pch.h"
#include "DependencyResolverFactory.h"
#include "IDependencyResolver.h"
#include "HypodermicAdapter.h"
#include "BoostDIAdapter.h"
#include "FruitAdapter.h"
#include <boost/property_tree/xml_parser.hpp>
#include <boost/property_tree/ptree_fwd.hpp>

using namespace std;

std::string DependencyResolverFactory::m_sFilePath;
std::shared_ptr<boost::property_tree::ptree> DependencyResolverFactory::m_pInputXMLTree;

std::unique_ptr<IDependencyResolver> DependencyResolverFactory::CreateDependencyResolver() const
{
	string sContainerName = GetContainerName();
	// TODO: this need to be some form of map lookup
	// 
	unique_ptr<IDependencyResolver> upDr;
	int nCmp = -1;

	if ((nCmp = sContainerName.compare(CONTAINERNAME_HYPODERMIC)) == 0)
	{
		upDr.reset(new HypodermicAdapter());
	}
	else if ((nCmp = sContainerName.compare(CONTAINERNAME_BOOSTDI)) == 0)
	{
		upDr.reset(new BoostDIAdapter());
	}
	else if ((nCmp = sContainerName.compare(CONAINERNAME_FRUIT)) == 0)
	{
		upDr.reset(new FruitAdapter());
	}
	else
	{
		std::stringstream errMsg;
		errMsg << "Container name '" << sContainerName << "' is not valid.";
		throw std::exception(errMsg.str().c_str());
	}
	return upDr;
}

std::string DependencyResolverFactory::GetContainerName() const
{
	string sContainerName;
	const string sFilePath = ".\\props.xml";
	boost::property_tree::ptree *pInputXMLTree = new boost::property_tree::ptree();
	// avoid &#10 and &#9 garbage with flags
	read_xml(sFilePath, *pInputXMLTree, (boost::property_tree::xml_parser::no_comments | boost::property_tree::xml_parser::trim_whitespace));
	const boost::optional<std::string> boContainerName =
		pInputXMLTree->get_optional<std::string>("configuration.appSettings.container.<xmlattr>.name");

	if (boContainerName)
	{
		sContainerName = boContainerName.get();
	}
	else
	{
		std::stringstream errMsg;
		errMsg << "Could not find container name in '" << sFilePath << "'";
		throw std::exception(errMsg.str().c_str());
	}
	return ContainerNameToLower(sContainerName);
}

std::string DependencyResolverFactory::ContainerNameToLower(std::string sName) const
{
	std::string sRet = sName;
	std::for_each(sRet.begin(), sRet.end(), [](char & c) {	c = ::tolower(c); });
	return sRet;
}

DependencyResolverFactory::DependencyResolverFactory()
{
	m_sFilePath = ".\\props.xml";
	m_pInputXMLTree.reset(new boost::property_tree::ptree());
}
