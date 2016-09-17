using UnityEngine;

namespace Assets.Lecture3
{
	public class SwordAction : ISoldierAction
	{
		public static SwordAction Get()
		{
			return new SwordAction();
		}

		public void Attack()
		{
			Debug.Log( "SwordMan : Sword Attack!!" );
		}
	}
}
