using Sandbox;

partial class MoonbaseHostPlayer : Player
{
	public override void Respawn()
	{
		SetModel( "models/citizen/citizen.vmdl" );

		EnableAllCollisions = false;
		EnableDrawing = false;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = false;

		base.Respawn();
	}
}
