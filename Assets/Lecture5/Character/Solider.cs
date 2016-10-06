using UnityEngine;

namespace Assets.Lecture5
{
	public abstract class Solider : MonoBehaviour
												, ICharacter
	{
		public virtual string Name { get; set; }
		public abstract void RegisterFX( IFXFactory fxMaker );
		public abstract void SetRespawn();
	}
}
