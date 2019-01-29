#pragma once
#include "IMessageOfTheDay.h"
#include "IDevMorningFix.h"
#include "IOutputProvider.h"

class DefaultOutputProvider;

class DevMorningFix: public IDevMorningFix
{
public:
	DevMorningFix() = delete;
	virtual ~DevMorningFix() = default;
	DevMorningFix(std::shared_ptr<IOutputProvider> upOp , std::shared_ptr<IMessageOfTheDay> upMp);

	void Start() const override;

private:
	std::shared_ptr<IOutputProvider> m_outputprovider;
	std::shared_ptr<IMessageOfTheDay> m_messageProvider;
};

