using UnrealBuildTool;

public class AI_AvatarTarget : TargetRules
{
	public AI_AvatarTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AI_Avatar");
	}
}
