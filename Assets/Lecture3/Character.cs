using UnityEngine;
using System.Collections;

using ReadOnlys;

public class Character : MonoBehaviour
{
	public Animator animator = null;

	private void Awake()
	{
		Debug.Assert( null != animator, "Check Animator!!!!" );
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
		if( animator.GetCurrentAnimatorStateInfo(0).fullPathHash != Lecture3.AnimationID.SwordWait )
		{
			return;
		}

		Debug.LogError("Attttttttttttttttttttttack");
		animator.SetInteger( Lecture3.AnimationID.SwordState, Lecture3.Action.Attack.ToInt() );

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

		animator.SetInteger( Lecture3.AnimationID.SwordState, Lecture3.Action.Idle.ToInt() );
	}
}
