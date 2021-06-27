using Sandbox;

public partial class MoonbaseGame : Sandbox.Game
{

	[ServerCmd( "sv_gravity" )]
	public static void changeGravityToMoon()
	{
		ConsoleSystem.SetValue( "sv_gravity", 132.8f );
	}

	[ServerCmd("playsound")]
	public static void playMusic()
	{
		ConsoleSystem.SetValue( "playsound", "music_martian_cowboy" );
	}

	public override void ClientJoined( Client cl )
	{
		base.ClientJoined( cl );

		var player = new MoonbasePlayer();
		cl.Pawn = player;

		playMusic();
		changeGravityToMoon();
		
		player.Respawn();
	}
	
}
