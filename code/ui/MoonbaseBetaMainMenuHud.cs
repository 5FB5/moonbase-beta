using Sandbox;
using Sandbox.UI;

[Library]
public partial class MoonbaseBetaMainMenuHud : HudEntity<RootPanel>
{
	public MoonbaseBetaMainMenuHud()
	{
		if ( !IsClient )
			return;

		RootPanel.StyleSheet.Load( "styles/MoonbaseBetaMainMenuHud.scss" );

		RootPanel.AddChild<NameTags>();
		RootPanel.AddChild<CrosshairCanvas>();
		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<VoiceList>();
		RootPanel.AddChild<KillFeed>();
		RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();

	}
}


