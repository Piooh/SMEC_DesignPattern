using UnityEngine;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class ChasingTarget : IMonsterBehavior
	{
		public static ChasingTarget Get()			{ return new ChasingTarget(); }

		public void Enter( MonsterStateCtrl stateCtrl, Monster mob )
		{
			Debug.Log( "Enter the ChasingTarget" );
		}

		public void Update( MonsterStateCtrl stateCtrl, Monster mob )
		{
			if( null == mob.AggroTarget )
			{
				stateCtrl.ChangeBehavior( RoamingAround.Get() );
			}
			else
			{
				var targetPos			= mob.AggroTarget.position;
				var pos						= mob.transform.position;
				var distance				= (targetPos - pos).sqrMagnitude;

				if( distance <= mob.attackReach )
				{
					stateCtrl.ChangeBehavior( AttackTarget.Get() );
				}
				else
				{
					var dir								=	(targetPos - pos).normalized;
					mob.transform.rotation	= Quaternion.LookRotation( dir );
					mob.transform.position	= mob.transform.position + ( dir * mob.moveSpeed * Time.deltaTime );
				}
			}
		}

		public void Exit( MonsterStateCtrl stateCtrl, Monster mob )
		{
			Debug.Log( "Exit the ChasingTarget" );
		}
	}
}
