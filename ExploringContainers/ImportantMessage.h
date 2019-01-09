#pragma once
#include "IMessageOfTheDay.h"

class ImportantMessage : public IMessageOfTheDay
{
public:
	ImportantMessage();
	std::string GetMessage() override;

	virtual ~ImportantMessage() = default;
};

