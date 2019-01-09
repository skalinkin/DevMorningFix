#pragma once
#include <iostream>

class DevMorningFix
{
public:
	DevMorningFix(std::ostream& output);
	virtual ~DevMorningFix();
	void Start();
private:
	ostream m_outstream;
};

