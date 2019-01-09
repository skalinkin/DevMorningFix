#pragma once
#include <string>

class IMessageOfTheDay
{
public:
	virtual ~IMessageOfTheDay() = default;

	std::string virtual GetMessage() = 0;
};
