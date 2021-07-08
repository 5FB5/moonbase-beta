using Sandbox;
using Sandbox.UI;

namespace MoonbaseBeta
{
	[Library]
	public class MainMenuHud : Sandbox.HudEntity<RootPanel>
	{
		public MainMenuHud()
		{
			if ( !IsClient )
				return;

			RootPanel.SetTemplate( "code/ui/MainMenuHud.html" );
			RootPanel.StyleSheet.Load( "code/ui/styles/MainMenuHud.scss" );

			RootPanel.AddChild<MenuButtons>();
			RootPanel.AddChild<ChatBox>();
		}

	}

}
