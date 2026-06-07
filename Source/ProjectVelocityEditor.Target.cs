using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVelocityEditorTarget : TargetRules
{
	public ProjectVelocityEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V6;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		bOverrideBuildEnvironment = true;
		ExtraModuleNames.Add("ProjectVelocity");
	}
}
