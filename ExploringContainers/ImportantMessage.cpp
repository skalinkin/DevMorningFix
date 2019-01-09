#include "pch.h"
#include "ImportantMessage.h"


ImportantMessage::ImportantMessage()
{
}

std::string ImportantMessage::GetMessage()
{
	std::string sMotd = "Hello World! C++ is waaaay cool.\n";
	return sMotd;
}
