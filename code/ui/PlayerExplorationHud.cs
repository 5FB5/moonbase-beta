using Sandbox;
using Sandbox.UI;

namespace MoonbaseBeta
{
	[Library]
	public partial class PlayerExplorationHud : HudEntity<RootPanel>
	{
		public PlayerExplorationHud()
		{
			if ( !IsClient )
				return;

			RootPanel.StyleSheet.Load( "styles/PlayerExplorationHud.scss" );

			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<CrosshairCanvas>();
			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<VoiceList>();
			RootPanel.AddChild<KillFeed>();
			RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();

		}
	}
}
