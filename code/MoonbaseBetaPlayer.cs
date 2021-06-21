using Sandbox;

partial class MoonbasePlayer : Player
{
	public override void Respawn()
	{
		SetModel( "models/citizen/citizen.vmdl" );

		Controller = new MoonWalkController();
		Animator = new StandardPlayerAnimator();
		Camera = new ThirdPersonCamera();

		EnableAllCollisions = true;
		EnableDrawing = true;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;

		base.Respawn();
	}
}
