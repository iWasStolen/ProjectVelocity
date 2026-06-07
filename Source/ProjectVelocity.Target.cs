using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVelocityTarget : TargetRules
{
	public ProjectVelocityTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		bOverrideBuildEnvironment = true;
		ExtraModuleNames.Add("ProjectVelocity");
	}
}
