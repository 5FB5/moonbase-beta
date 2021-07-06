using Sandbox;

namespace MoonbaseBeta
{
	public class MenuCamera : FixedCamera
	{
		public override void Update()
		{
			base.Update();

			var rotation = Rotation.FromPitch( 15f );

			Pos = new Vector3( -2024.0f, -1024.0f, 1024.0f );
			Rot = rotation;
		}
	}
}
