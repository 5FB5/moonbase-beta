using Sandbox;
using Sandbox.UI;

[Library]
public partial class MoonbaseBetaPlayerExplorationHud : HudEntity<RootPanel>
{
	public MoonbaseBetaPlayerExplorationHud()
	{
		if ( !IsClient )
			return;

		RootPanel.StyleSheet.Load( "styles/MoonbaseBetaPlayerExplorationHud.scss" );

		RootPanel.AddChild<NameTags>();
		RootPanel.AddChild<CrosshairCanvas>();
		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<VoiceList>();
		RootPanel.AddChild<KillFeed>();
		RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();

	}
}


