#pragma once
#include "IMessageOfTheDay.h"

class ImportantMessage : public IMessageOfTheDay
{
public:
	ImportantMessage();
	virtual ~ImportantMessage() = default;

	std::string GetMessage() override;
};

