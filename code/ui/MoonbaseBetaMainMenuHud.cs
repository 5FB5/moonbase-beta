using Sandbox;
using Sandbox.UI;

public partial class MoonbaseBetaMainMenuHud : Sandbox.HudEntity<RootPanel>
{
	public MoonbaseBetaMainMenuHud()
	{
		if ( IsClient )
		{
			RootPanel.SetTemplate( "ui/MoonbaseBetaMainMenuHud.html" );
			Log.Warning( "[MoonbaseBeta -> MoonbaseBetaMainMenuHud.cs] 'MoonbaseBetaMainMenuHud.html' loaded!" );
		}
	}
}
