#pragma once
#include "IMessageOfTheDay.h"
#include "IDevMorningFix.h"

class DevMorningFix: public IDevMorningFix
{
public:
	DevMorningFix() = delete;
	virtual ~DevMorningFix() = default;
	DevMorningFix(std::ostream&, std::unique_ptr<IMessageOfTheDay> upMp);

	void Start() const override;

private:
	std::ostream& m_outstream;
	std::unique_ptr<IMessageOfTheDay> m_messageProvider;
};

