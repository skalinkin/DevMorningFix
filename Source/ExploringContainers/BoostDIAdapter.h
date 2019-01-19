#pragma once

#include "IDependencyResolver.h"

class BoostDIAdapter : public IDependencyResolver
{
public:
	BoostDIAdapter() = default;
	virtual ~BoostDIAdapter() = default;
	std::shared_ptr<IDevMorningFix> GetApp() override;
};

