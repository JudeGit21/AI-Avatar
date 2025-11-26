using UnrealBuildTool;

public class AI_AvatarClientTarget : TargetRules
{
	public AI_AvatarClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("AI_Avatar");
	}
}
