// ExploringContainers.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

int main()
{
	//TODO: First step is to split our small business logic from execution environment. 
	//TODO: I want to have another class i.e. DevMorningFixApp (correct the style for C++) with a method Run which contains following line.  
    std::cout << "Hello World!\n"; 
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
//  http://boost-experimental.github.io/di/
//  https://github.com/boost-experimental/di
//
// Allegedly inspired by Autofac
// https://github.com/ybainier/Hypodermic
//https://github.com/ybainier/Hypodermic/wiki/Getting-started
//
// 
