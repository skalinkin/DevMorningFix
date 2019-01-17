#pragma once
#include "IOutputProvider.h"
class DefaultOutputProvider : public IOutputProvider
{
public:
	DefaultOutputProvider() = default;
	virtual ~DefaultOutputProvider() = default;
	std::ostream&  Provide() const override;
};

