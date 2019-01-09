#pragma once
#include <iostream>

class DevMorningFix
{
public:
	DevMorningFix(std::ostream& output);
	virtual ~DevMorningFix();
	static void Start();
private:
	std::ostream& m_outstream;
};

