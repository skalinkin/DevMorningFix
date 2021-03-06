// ExploringContainers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include "DevMorningFix.h"
#include "IDependencyResolver.h"
#include "HypodermicAdapter.h"
#include "DependencyResolverFactory.h"

using namespace std;

int main()
{
	// were this not an exe this would leak
	// DevMorningFix* app = new DevMorningFix(std::cout);
	// 
	// a corresponding delete[] app would be needed to plug the leak
	// 
	// This is life without garbage collection the new/delete pairing.
	// So-called smart pointers help alleviate some of our woes in C++ land.
	//
	// Smart pointers self destruct when going out of scope
	// unique means ownership transfer only by std::move (as opposed to assignment, which is copy)
	// (there is also a smart shared pointer that is reference counted. 
	//		Every assignment bumps the ref count.
	//		Every time it goes out of scope decrements the ref count.
	//      The pointer goes away when the ref count is 0 - out of scope for the last time)
	// 
	// I'll be interested to see if there are any issues for whatever container injecting a unique_ptr.
	//	Because I am unsure as to whether the container will be the owner at creation time
	//		and then move ownership
	//		or it is automagically taken care of by some means
	//		or maybe none of this matters
	//	
	//	Factory is monostate
	auto upDependencyResolverFactory = std::make_unique<DependencyResolverFactory>()->CreateDependencyResolver();
	const auto app = upDependencyResolverFactory->GetApp();
	app->Start();
}

// Container implementations to choose from (IMO)
// 
// My first 'choice'. Widely used in the real world. LOTS of eyeballs on it.
// https://github.com/google/fruit/wiki/quick-reference
// https://github.com/google/fruit/wiki/tutorial:-getting-started
// https://stackoverflow.com/questions/37099317/c-dependency-injection-with-fruit  the author is available
// 
// Wanting to see what's up with this. (Experimental).
// Particularly
// XML Injection Extension
// Mocks provider - so you can test without the container itself being a dependency
// http://boost-experimental.github.io/di/
// https://github.com/boost-experimental/di
//
// Allegedly inspired by Autofac
// https://github.com/ybainier/Hypodermic
// https://github.com/ybainier/Hypodermic/wiki/Getting-started
//
// 
