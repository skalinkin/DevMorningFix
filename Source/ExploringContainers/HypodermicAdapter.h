#pragma once
#include "IDependencyResolver.h"
#include <ContainerBuilder.h>

class HypodermicAdapter:public IDependencyResolver
{
public:
	HypodermicAdapter();
	virtual ~HypodermicAdapter();
	std::shared_ptr<IDevMorningFix> GetApp() override;
};

