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

DevMorningFix::DevMorningFix(std::shared_ptr<IOutputProvider> upOp, std::shared_ptr<IMessageOfTheDay> upMp)
	: m_outputprovider(upOp)
	, m_messageProvider(upMp)
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
	std::ostream& output = m_outputprovider->Provide();
	output << sMsg;
}

