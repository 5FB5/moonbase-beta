using Sandbox;
using Sandbox.UI;

[Library]

public partial class MoonbaseBetaHud : HudEntity<RootPanel>
{
	public MoonbaseBetaHud()
	{
		if ( !IsClient )
			return;

		RootPanel.AddChild<ChatBox>();
	}
}


