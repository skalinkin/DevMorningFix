#include "pch.h"
#include "DevMorningFix.h"

/*******************************************************************************/
/*!
* Constructor.
*
* @param [in,out]	output	The output stream.
* @param 		 	upMp  	unique_ptr to message provider.
*/
/*******************************************************************************/

DevMorningFix::DevMorningFix(std::ostream& output, std::unique_ptr<IMessageOfTheDay> upMp)
	: m_outstream(output)
	, m_messageProvider(std::move(upMp))
{
}

/*******************************************************************************/
/*!
* Starts the app business logic.
*/
/*******************************************************************************/

void DevMorningFix::Start() const
{
	const std::string sMsg = m_messageProvider->GetMessage();
	m_outstream << sMsg;
}

