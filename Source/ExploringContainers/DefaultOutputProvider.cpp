#include "pch.h"
#include "DefaultOutputProvider.h"
#include <iostream>

std::ostream & DefaultOutputProvider::Provide() const
{
	return std::cout;
}
