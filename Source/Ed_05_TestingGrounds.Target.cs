// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Ed_05_TestingGroundsTarget : TargetRules
{
	public Ed_05_TestingGroundsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Ed_05_TestingGrounds");
	}
}
