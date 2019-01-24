#pragma once
#include "IDependencyResolver.h"
#include <fruit/fruit.h>

class FruitAdapter :
	public IDependencyResolver
{
public:
	FruitAdapter() = default;
	virtual ~FruitAdapter() = default;
	std::shared_ptr<IDevMorningFix> GetApp() override;
};

