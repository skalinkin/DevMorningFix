#include "pch.h"
#include "DevMorningFix.h"

DevMorningFix::DevMorningFix(std::ostream& output) 
	: m_outstream (output)
{
}

void DevMorningFix::Start()
{
	std::cout << "Hello World!\n"; 
}

DevMorningFix::~DevMorningFix()
{
}
