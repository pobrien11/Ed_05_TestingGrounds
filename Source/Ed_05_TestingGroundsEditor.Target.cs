// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Ed_05_TestingGroundsEditorTarget : TargetRules
{
	public Ed_05_TestingGroundsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Ed_05_TestingGrounds");
	}
}
