using UnityEngine;

namespace Assets.Lecture5
{
	public class Slime : Monster
	{
		private FXAura aura	= null;

		public override void SetupFactor()
		{
			Factor = SlimeFactors.Create();
		}

		public override void RegisterFX( IFXFactory fxMaker )
		{
			aura								= fxMaker.CreateAura();
			aura.transform.parent	= transform;
		}

		public override void SetRespawn()
		{
		}
	}
}
