// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnTerraria : ModuleRules
{
	public UnTerraria(ReadOnlyTargetRules Target) : base(Target)
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
			"UnTerraria",
			"UnTerraria/Variant_Platforming",
			"UnTerraria/Variant_Platforming/Animation",
			"UnTerraria/Variant_Combat",
			"UnTerraria/Variant_Combat/AI",
			"UnTerraria/Variant_Combat/Animation",
			"UnTerraria/Variant_Combat/Gameplay",
			"UnTerraria/Variant_Combat/Interfaces",
			"UnTerraria/Variant_Combat/UI",
			"UnTerraria/Variant_SideScrolling",
			"UnTerraria/Variant_SideScrolling/AI",
			"UnTerraria/Variant_SideScrolling/Gameplay",
			"UnTerraria/Variant_SideScrolling/Interfaces",
			"UnTerraria/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
