using UnityEngine;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class AttackTarget : IMonsterBehavior
	{
		public static AttackTarget Get()			{ return new AttackTarget(); }

		private float delay = 0f;

		public void Enter( MonsterStateCtrl stateCtrl, Monster mob )
		{
			Debug.Log( "Enter the AttackTarget" );
			delay		= mob.attackSpeed;
		}

		public void Update( MonsterStateCtrl stateCtrl, Monster mob )
		{
			if( null != mob )
			{
				var targetPos			= mob.AggroTarget.position;
				var pos						= mob.transform.position;
				var distance				= (targetPos - pos).sqrMagnitude;
				
				if( distance <= mob.attackReach )
				{
					Attack( mob );
					return;
				}
			}

			stateCtrl.ChangeBehavior( ChasingTarget.Get() );
		}

		public void Exit( MonsterStateCtrl stateCtrl, Monster mob )
		{
			Debug.Log( "Exit the AttackTarget" );
		}

		private void Attack( Monster mob )
		{
			delay += Time.deltaTime;

			if( delay >= mob.attackSpeed )
			{
				delay = 0f;

				Debug.LogWarning( "Attack!!" );
			}
		}
	}
}
