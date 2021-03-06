// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#pragma once 

#include "CoreMinimal.h"
#include "GameFramework/HUD.h"
#include "Ed_05_TestingGroundsHUD.generated.h"

UCLASS()
class AEd_05_TestingGroundsHUD : public AHUD
{
	GENERATED_BODY()

public:
	AEd_05_TestingGroundsHUD();

	/** Primary draw call for the HUD */
	virtual void DrawHUD() override;

private:
	/** Crosshair asset pointer */
	class UTexture2D* CrosshairTex;

};

