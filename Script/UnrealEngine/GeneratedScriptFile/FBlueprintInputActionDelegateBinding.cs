using System;
namespace UnrealEngine
{
	public partial struct FBlueprintInputActionDelegateBinding
	{
		public FName InputActionName;
		public EInputEvent InputKeyEvent;
		public FName FunctionNameToBind;
		public bool bConsumeInput;
		public bool bExecuteWhenPaused;
		public bool bOverrideParentBinding;
		
	}
	
}
