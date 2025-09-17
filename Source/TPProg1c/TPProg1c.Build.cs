// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TPProg1c : ModuleRules
{
	public TPProg1c(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TPProg1c",
			"TPProg1c/Variant_Platforming",
			"TPProg1c/Variant_Platforming/Animation",
			"TPProg1c/Variant_Combat",
			"TPProg1c/Variant_Combat/AI",
			"TPProg1c/Variant_Combat/Animation",
			"TPProg1c/Variant_Combat/Gameplay",
			"TPProg1c/Variant_Combat/Interfaces",
			"TPProg1c/Variant_Combat/UI",
			"TPProg1c/Variant_SideScrolling",
			"TPProg1c/Variant_SideScrolling/AI",
			"TPProg1c/Variant_SideScrolling/Gameplay",
			"TPProg1c/Variant_SideScrolling/Interfaces",
			"TPProg1c/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
