using Sandbox;
using Sandbox.UI;

namespace MoonbaseBeta
{
	public class MainMenuHud : Sandbox.HudEntity<RootPanel>
	{
		public MainMenuHud()
		{
			if ( !IsClient )
				return;

			RootPanel.SetTemplate( "ui/MainMenuHud.html" );

			Log.Warning( "[MoonbaseBeta -> MoonbaseBetaMainMenuHud.cs] 'MoonbaseBetaMainMenuHud.html' loaded!" );
		}
		public void Test()
		{
			Log.Info( "Test" );
		}
	}
}
