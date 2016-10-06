using UnityEngine;

namespace Assets.Lecture5
{
	public abstract class Monster : MonoBehaviour
													, ICharacter
	{
		public float roamingResetTime	= 3f;
		public float roamingMaxDist		= 10f;
		public float moveSpeed				= 2f;



		public virtual string Name { get; set; }
		public abstract void RegisterFX( IFXFactory fxMaker );
		public abstract void SetRespawn();
	}
}
