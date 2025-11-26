using UnrealBuildTool;

public class AI_AvatarEditorTarget : TargetRules
{
	public AI_AvatarEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("AI_Avatar");
	}
}
