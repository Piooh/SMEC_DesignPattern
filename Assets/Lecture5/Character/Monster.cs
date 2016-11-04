using UnityEngine;

namespace Assets.Lecture5
{
	public abstract class Monster : MonoBehaviour
													, ICharacter
	{
		public virtual MonsterFactors Factor			{ get;	protected set; }
		public virtual Transform AggroTarget		{ get;	set; }

		public virtual void SetAvatarInfo()				{ }
		public abstract void SetupFactor();
		public abstract void SetRespawn();
		public abstract void RegisterFX( IFXFactory fxMaker );
	}
}
