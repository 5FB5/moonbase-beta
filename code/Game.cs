using Sandbox;

public partial class MoonbaseGame : Sandbox.Game
{
	public MoonbaseGame()
	{
		if (IsServer)
		{
			//ConsoleSystem.Run( "sv_gravity 132.8" );
			//Log.Info( "Server: sv_gravity 132.8" );

			ConsoleSystem.Run( "playsound music_martian_cowboy" );
			Log.Info( "Server: playsound music_martian_cowboy" );

			new MoonbaseBetaMainMenuHud();
		}

	}

	public override void ClientJoined( Client cl )
	{
		base.ClientJoined( cl );
		var player = new MoonbasePlayer();
		cl.Pawn = player;

		player.Respawn();
	}
}
