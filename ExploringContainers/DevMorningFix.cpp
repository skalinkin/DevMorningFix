#include "pch.h"
#include "DevMorningFix.h"

DevMorningFix::DevMorningFix(std::ostream& output) 
	: m_outstream (output)
{
}

void DevMorningFix::Start()
{
	std::cout << "Hello World! C++ is waaaay cool.\n"; 
}

DevMorningFix::~DevMorningFix()
{
}
