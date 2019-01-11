//TODO: Since this is does not belong to presentation layer we need to move from here. At least to DevMorningFix
#include "pch.h"
#include "ImportantMessage.h"
using namespace std;

/*******************************************************************************/
/*!
* Default constructor.
*/
/*******************************************************************************/

ImportantMessage::ImportantMessage()
{
}

/*******************************************************************************/
/*!
* Gets the message of the day.
*
* @return	The message.
*/
/*******************************************************************************/

string ImportantMessage::GetMessage()
{
	string sMotd = "Hello World! C++ is waaaay cool.\n";
	return sMotd;
}
