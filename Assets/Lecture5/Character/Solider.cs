using UnityEngine;

namespace Assets.Lecture5
{
	public abstract class Solider : MonoBehaviour
												, ICharacter
	{
		public AvatarInfo Info { get; set; }
		public abstract void SetAvatarInfo();
		public abstract void RegisterFX( IFXFactory fxMaker );
		public abstract void SetRespawn();
	}
}
