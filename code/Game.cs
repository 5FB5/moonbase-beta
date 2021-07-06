using Sandbox;

namespace MoonbaseBeta
{
	public class MoonbaseGame : Sandbox.Game
	{
		public MoonbaseGame()
		{
			if ( IsServer )
			{
				Log.Info( "[MoonbaseBeta] You've connected as HOST" );

				new MoonbaseBeta.MainMenuHud();
				Log.Warning( "[MoonbaseBeta] Starting 'MoonbaseBetaMainMenuHud()'..." );

				ConsoleSystem.Run( "sv_gravity 132.8" );
				Log.Info( "Server: sv_gravity 132.8" );
			}

		}
		public override void ClientJoined( Client cl )
		{
			base.ClientJoined( cl );

			// For host
			if ( IsServer )
			{
				cl.Camera = new MoonbaseBeta.MenuCamera();

				//if ( isExplorationStarted == true )
				//{
				//	new MoonbaseBeta.PlayerExplorationHud();

				//	var player = new MoonbaseBeta.ExplorationPlayer();
				//	cl.Pawn = player;
					
				//	player.Respawn();
				//}
			}

		}
		public override void Shutdown()
		{
			ConsoleSystem.Run( "sv_gravity 600" );
			Log.Info( "Server (Shutdown): sv_gravity 600" );

			base.Shutdown();
		}
	}
}
