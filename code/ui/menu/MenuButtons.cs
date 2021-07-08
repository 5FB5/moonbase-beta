using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class MenuButtons : Panel
{
	public MenuButtons()
	{
		SetClass( "menubuttons", true );
		Add.Label( "Hello", "menubuttons" );
	}
}
