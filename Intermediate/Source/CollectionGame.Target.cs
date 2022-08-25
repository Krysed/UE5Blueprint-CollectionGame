using UnrealBuildTool;

public class CollectionGameTarget : TargetRules
{
	public CollectionGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CollectionGame");
	}
}
