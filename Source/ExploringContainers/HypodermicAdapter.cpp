#include "pch.h"
#include "HypodermicAdapter.h"
#include "Hypodermic/ContainerBuilder.h"
#include "ImportantMessage.h"
using namespace Hypodermic;


HypodermicAdapter::HypodermicAdapter() = default;


HypodermicAdapter::~HypodermicAdapter() = default;

std::shared_ptr<IDevMorningFix> HypodermicAdapter::GetApp()
{
	ContainerBuilder builder;
	builder.registerType<ImportantMessage>().as<IMessageOfTheDay>();
	//builder.registerType<cout>().as<std::ostream>();

	//builder.registerType<DevMorningFix>().as<IDevMorningFix>();
	//auto container = builder.build();
	//auto app = container->resolve<IDevMorningFix>();
	//return app;
	return {};
}
