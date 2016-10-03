using UnityEngine;

namespace Assets.Lecture5
{
	public class Slime : MonoBehaviour
							, IMonster
	{
		public string Name { get; set; }

		private FXAura aura	= null;

		public void RegisterFX( IFXFactory fxMaker )
		{
			aura				= fxMaker.CreateAura();
			aura.transform.parent = transform;
		}

		public void SetRespawn()
		{
		}
	}
}
