using Sandbox;
using Sandbox.UI;

[Library]
public partial class MoonbaseBetaHud : HudEntity<RootPanel>
{
	public MoonbaseBetaHud()
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


