#include "pch.h"
#include "FruitAdapter.h"
#include "ImportantMessage.h"
#include "IOutputProvider.h"
#include "DefaultOutputProvider.h"

std::shared_ptr<IDevMorningFix> FruitAdapter::GetApp()
{
	// stub
	return std::make_shared<IDevMorningFix>();
}
