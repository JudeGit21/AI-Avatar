using UnrealBuildTool;

public class AI_AvatarServerTarget : TargetRules
{
	public AI_AvatarServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("AI_Avatar");
	}
}
