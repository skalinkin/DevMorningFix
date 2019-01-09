#include "pch.h"
#include "DevMorningFix.h"
using namespace std;

DevMorningFix::DevMorningFix(std::ostream& output) 
	: m_outstream (output)
{
}

void DevMorningFix::Start()
{
    cout << "Hello World!\n"; 
}

DevMorningFix::~DevMorningFix()
{
}
