using Sandbox;

public partial class MoonbaseGame : Sandbox.Game
{
	public override void ClientJoined( Client cl )
	{
		base.ClientJoined( cl );

		var player = new MoonbasePlayer();
		cl.Pawn = player;

		player.Respawn();
	}
}
