#include "pch.h"
#include "BoostDIAdapter.h"
#include <boost/di.hpp>
#include "ImportantMessage.h"
#include "IOutputProvider.h"
#include "DefaultOutputProvider.h"

namespace di = boost::di;

std::shared_ptr<IDevMorningFix> BoostDIAdapter::GetApp()
{
	auto injector = di::make_injector(
		  di::bind<IMessageOfTheDay>.to<ImportantMessage>()
		, di::bind<IOutputProvider>.to<DefaultOutputProvider>()
		, di::bind<IDevMorningFix>.to<DevMorningFix>()
	);

	auto app = injector.create< std::shared_ptr<IDevMorningFix>>();

	return app;
}
