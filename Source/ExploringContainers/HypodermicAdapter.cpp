#include "pch.h"
#include "HypodermicAdapter.h"
#include "Hypodermic/ContainerBuilder.h"
#include "ImportantMessage.h"
#include "IOutputProvider.h"
#include "DefaultOutputProvider.h"
using namespace Hypodermic;

std::shared_ptr<IDevMorningFix> HypodermicAdapter::GetApp()
{
	ContainerBuilder builder;
	builder.registerType<ImportantMessage>().as<IMessageOfTheDay>();
	builder.registerType<DefaultOutputProvider>().as<IOutputProvider>();
	builder.registerType<DevMorningFix>().as<IDevMorningFix>();
	auto container = builder.build();
	auto app = container->resolve<IDevMorningFix>();
	return app;
}
