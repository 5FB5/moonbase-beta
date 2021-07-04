using Sandbox;
using Sandbox.UI;

[Library]
public partial class MoonbaseBetaExplorationHud : HudEntity<RootPanel>
{
	public MoonbaseBetaExplorationHud()
	{
		if ( !IsClient )
			return;

		RootPanel.StyleSheet.Load( "ui/MoonbaseBetaExplorationHud.scss" );
		Log.Info("[MoonbaseBeta] 'MoonbaseBetaExplorationHud.scss' loaded");

		RootPanel.AddChild<NameTags>();
		RootPanel.AddChild<CrosshairCanvas>();
		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<VoiceList>();

	}
}


