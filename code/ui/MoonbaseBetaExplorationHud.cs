using Sandbox;
using Sandbox.UI;

[Library]
public partial class MoonbaseBetaExplorationHud : HudEntity<RootPanel>
{
	public MoonbaseBetaExplorationHud()
	{
		if ( !IsClient )
			return;

		RootPanel.StyleSheet.Load( "ui/MoonbaseBetaHud.scss" );

		RootPanel.AddChild<NameTags>();
		RootPanel.AddChild<CrosshairCanvas>();
		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<VoiceList>();
		RootPanel.AddChild<KillFeed>();
		RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();

	}
}


