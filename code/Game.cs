using Sandbox;

public partial class MoonbaseGame : Sandbox.Game
{
	public MoonbaseGame()
	{
		if (IsServer)
		{
			Log.Info( "[MoonbaseBeta] You've connected as HOST" );

			ConsoleSystem.Run( "sv_gravity 132.8" );
			Log.Info( "Server: sv_gravity 132.8" );
		}

	}
	public override void ClientJoined( Client cl )
	{
		base.ClientJoined( cl );

		var player = new MoonbasePlayer();
		cl.Pawn = player;

		player.Respawn();
	}

	public override void Shutdown()
	{
		ConsoleSystem.Run( "sv_gravity 600" );
		Log.Info( "Server (Shutdown): sv_gravity 600" );

		base.Shutdown();
	}
}
