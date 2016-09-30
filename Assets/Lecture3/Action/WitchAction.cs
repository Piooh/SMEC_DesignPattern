using UnityEngine;
using System.Collections;
using Assets.Lecture3.ReadOnlys;

namespace Assets.Lecture3
{
	public class WitchAction : ISoldierAction
	{
		private Animator animator = null;

		public static WitchAction Get( Animator animator )
		{
			var action				= new WitchAction();
			action.animator	= animator;

			return null == action.animator ? null : action;
		}

		public void Attack()
		{
			if( animator.GetCurrentAnimatorStateInfo(0).fullPathHash != AnimationID.Idle )
			{
				return;
			}

			Debug.Log( "Witch : Magic Attack !!" );
			animator.SetInteger( AnimationID.AniState, Action.Attack.ToInt() );
		}

		public IEnumerator CheckAniEnd()
		{
			float playTime = 0f;
			float endTime = animator.GetCurrentAnimatorStateInfo(0).length;

			do
			{
				playTime  += 0.1f;
				yield return null;
			}
			while( playTime > endTime );

			animator.SetInteger( AnimationID.AniState, Action.Idle.ToInt() );
		}
	}
}
