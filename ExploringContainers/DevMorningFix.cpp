#include "pch.h"
#include "DevMorningFix.h"

DevMorningFix::DevMorningFix(std::ostream& output, IMessageOfTheDay* messageProvider)
	: m_outstream(output)
	, m_messageProvider(messageProvider)
{
}

void DevMorningFix::Start() const
{
	const std::string sMsg = m_messageProvider->GetMessage();
	m_outstream << sMsg;
}

