#pragma once
#include "IMessageOfTheDay.h"

class DevMorningFix
{
public:
	// if you don't provide these constructors, the compiler will (silently)
	// its good form to explicitly declare these
	// if you have nothing brilliant to add, then delete or default is ok
	//
	// Let's put these in and see if it affects any containers.
	// 
	DevMorningFix() = delete;
	DevMorningFix(DevMorningFix&&) = default;
	DevMorningFix& operator=(DevMorningFix&&) = default;	// move
	DevMorningFix(const DevMorningFix&) = default;
	DevMorningFix&operator=(const DevMorningFix&) = default;	// copy

	DevMorningFix(std::ostream&, IMessageOfTheDay*);
	virtual ~DevMorningFix() = default;
	void Start() const;

private:
	std::ostream& m_outstream;
	std::unique_ptr<IMessageOfTheDay> m_messageProvider;
};

