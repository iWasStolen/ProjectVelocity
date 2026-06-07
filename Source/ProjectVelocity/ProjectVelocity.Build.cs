using UnrealBuildTool;

public class ProjectVelocity : ModuleRules
{
	public ProjectVelocity(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"EnhancedInput",
			"ChaosVehicles",
			"UMG"
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
