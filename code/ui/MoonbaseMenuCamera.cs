using Sandbox;

public class MoonbaseMenuCamera : FixedCamera
{
	public override void Update()
	{
		base.Update();

		Pos = new Vector3( -2024.0f, -1024.0f, 1024.0f );
	}
}
