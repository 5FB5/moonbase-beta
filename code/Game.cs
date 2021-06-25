using Sandbox;

public partial class MoonbaseGame : Sandbox.Game
{
	static SoundEvent musicMain = new ( "sounds/music_martian_cowboy.vsnd" );

	[ServerCmd( "sv_gravity" )]
	public static void changeGravityToMoon()
	{
		ConsoleSystem.SetValue( "sv_gravity", 132.8f );
	}

	public override void ClientJoined( Client cl )
	{
		base.ClientJoined( cl );

		var player = new MoonbasePlayer();
		cl.Pawn = player;

		changeGravityToMoon();

		player.Respawn();
	}

	
}
