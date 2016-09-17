using UnityEngine;

namespace Assets.Lecture3
{
	public class MagicianAction : ISoldierAction
	{
		public static MagicianAction Get()
		{
			return new MagicianAction();
		}

		public void Attack()
		{
			Debug.Log( "Magician : Magic Attack !!" );
		}
	}
}
