using UnityEngine;

using Assets.Lecture8;

namespace Assets.Lecture5
{
	public abstract class Solider : MonoBehaviour
												, ICharacter
	{
		public AvatarInfo Info { get; set; }
		public abstract void SetAvatarInfo();
		public abstract void RegisterFX( IFXFactory fxMaker );
		public abstract void SetRespawn();
		public virtual void Move( Vector3 dir ) { }
	}
}
