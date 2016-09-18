using UnityEngine;

namespace Assets.Lecture3
{
	public class Solider : MonoBehaviour
	{
		public Animator animator					= null;
		protected ISoldierAction attackAction	= null;

		private void Awake()
		{
			Debug.Assert( null != animator, "Check Animator!!!!" );
			InitAction();
		}

		protected virtual void InitAction()
		{
			// do nothing...
		}

		private void FixedUpdate()
		{
			if( true == Input.GetMouseButtonUp(0) )
			{
				Attack();
			}
		}

		public void Attack()
		{
			if( null  == attackAction )		{ return; }

			attackAction.Attack();

			StartCoroutine( attackAction.CheckAniEnd() );
		}
	}
}
