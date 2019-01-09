#pragma once
#include "IMessageOfTheDay.h"

class DevMorningFix
{
public:
	DevMorningFix() = delete;
	virtual ~DevMorningFix() = default;
	DevMorningFix(std::ostream&, std::unique_ptr<IMessageOfTheDay> upMp);

	void Start() const;

private:
	std::ostream& m_outstream;
	std::unique_ptr<IMessageOfTheDay> m_messageProvider;
};

