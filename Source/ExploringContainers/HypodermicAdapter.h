#pragma once
#include "IDependencyResolver.h"
#include <ContainerBuilder.h>

class HypodermicAdapter:public IDependencyResolver
{
public:
	HypodermicAdapter() = default;
	virtual ~HypodermicAdapter() = default;
	std::shared_ptr<IDevMorningFix> GetApp() override;
};

