#pragma once
#pragma once
#include <ostream>

class IOutputProvider
{
public:
	virtual ~IOutputProvider() = default;

	virtual std::ostream&  Provide() const = 0;
};

