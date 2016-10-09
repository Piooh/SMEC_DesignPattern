using UnityEngine;

namespace Assets.Lecture5
{
	public abstract class Monster : MonoBehaviour
													, ICharacter
	{
		public float roamingResetTime	= 3f;
		public float roamingMaxDist		= 10f;
		public float searchRadius				= 13f;
		public float moveSpeed				= 2f;	
		public float attackReach				= 3f;
		public float attackSpeed				= 1.5f;

		public virtual string Name						{ get;		set; }
		public virtual Transform AggroTarget		{ get;		set; }

		public abstract void RegisterFX( IFXFactory fxMaker );
		public abstract void SetRespawn();
	}
}
