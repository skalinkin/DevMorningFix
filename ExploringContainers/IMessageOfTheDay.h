#pragma once
#include <string>

// 
// interfaces in C++ are abstract base classes
// if one method is marked as pure virtual then the class is an abstract base class
// setting the method to 0, i.e., the = 0 syntax makes it pure virtual
//  
class IMessageOfTheDay
{
public:
	virtual ~IMessageOfTheDay() = default;

	std::string virtual GetMessage() = 0;
};
