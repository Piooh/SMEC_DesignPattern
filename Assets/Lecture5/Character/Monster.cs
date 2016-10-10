using UnityEngine;

namespace Assets.Lecture5
{
	public abstract class Monster : MonoBehaviour
													, ICharacter
	{
		public virtual string Name						{ get;	set; }
		public virtual MonsterFactors Factor			{ get;	protected set; }
		public virtual Transform AggroTarget		{ get;	set; }

		public abstract void SetupFactor();
		public abstract void RegisterFX( IFXFactory fxMaker );
		public abstract void SetRespawn();
	}
}
