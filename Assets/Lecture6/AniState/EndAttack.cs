using UnityEngine;
using System.Collections;

using Assets.Lecture3.ReadOnlys;

namespace Assets.Lecture6
{
	public class EndAttack : StateMachineBehaviour
	{
		public override void OnStateEnter( Animator animator, AnimatorStateInfo stateInfo, int layerIndex )
		{
		}

		public override void OnStateUpdate( Animator animator, AnimatorStateInfo stateInfo, int layerIndex )
		{
			if( animator.recorderStopTime >= stateInfo.length )
			{
				animator.SetInteger( AnimationID.AniState, Action.Idle.ToInt() );
			}
		}

		public override void OnStateExit( Animator animator, AnimatorStateInfo stateInfo, int layerIndex )
		{
		}
	}
}

