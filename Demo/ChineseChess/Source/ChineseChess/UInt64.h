#pragma once
#include "Object.h"
struct Boolean;
struct Int32;
struct UInt64{
	public:
	
	Boolean op_Equals(Int32  b);
	public:
	
	Boolean op_Small(Int32  b);
	public:
	
	Int32 op_Assign(Int32  b);
	public:
	
	Int32 op_PlusPlus(Int32  b);
};
