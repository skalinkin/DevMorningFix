#pragma once
#include "DevMorningFix.h"
#include <Hypodermic/ContainerBuilder.h>

class IDependencyResolver
{
public:
	virtual ~IDependencyResolver() = default;
	std::shared_ptr<IDevMorningFix> virtual GetApp() = 0;
};
