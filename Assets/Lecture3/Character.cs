using UnityEngine;
using System.Collections;

using Assets.Lecture3.ReadOnlys;

namespace Assets.Lecture3
{
	public class Character : MonoBehaviour
	{
		public Animator animator = null;

		private ISoldierAction attackAction = null;

		private void Awake()
		{
			Debug.Assert( null != animator, "Check Animator!!!!" );

			//attackAction = SwordAction.Get();
			attackAction = MagicianAction.Get();
		}

		private void FixedUpdate()
		{
			if( true == Input.GetMouseButtonUp(0) )
			{
				Attack();
			}
		}

		private void Attack()
		{
			if( animator.GetCurrentAnimatorStateInfo(0).fullPathHash != AnimationID.SwordWait )
			{
				return;
			}

			attackAction.Attack();
			animator.SetInteger( AnimationID.SwordState, Action.Attack.ToInt() );

			StartCoroutine( CheckAniEnd() );
		}

		private IEnumerator CheckAniEnd()
		{
			float playTime = 0f;
			float endTime = animator.GetCurrentAnimatorStateInfo(0).length;

			do
			{
				playTime  += 0.1f;
				yield return null;
			}
			while( playTime > endTime );

			animator.SetInteger( AnimationID.SwordState, Action.Idle.ToInt() );
		}
	}
}
