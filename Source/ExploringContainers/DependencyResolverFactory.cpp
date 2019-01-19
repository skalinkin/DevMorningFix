#include "pch.h"
#include "DependencyResolverFactory.h"
#include "IDependencyResolver.h"
#include "HypodermicAdapter.h"
#include "BoostDIAdapter.h"
#include <boost/property_tree/xml_parser.hpp>
#include <boost/optional.hpp>
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

	if ((nCmp = sContainerName.compare("hypodermic")) == 0)
	{
		upDr.reset(new HypodermicAdapter());
	}
	else if ((nCmp = sContainerName.compare("boostdi")) == 0)
	{
		upDr.reset(new BoostDIAdapter());
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
	string sFilePath = ".\\props.xml";
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
	return sContainerName;
}

DependencyResolverFactory::DependencyResolverFactory()
{
	m_sFilePath = ".\\props.xml";
	m_pInputXMLTree.reset(new boost::property_tree::ptree());
}
