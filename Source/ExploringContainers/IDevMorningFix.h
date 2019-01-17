#pragma once
class IDevMorningFix
{
public:
	virtual ~IDevMorningFix() = default;

	void virtual Start() const = 0;
};
