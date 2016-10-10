using UnityEngine;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class RoamingAround : IMonsterBehavior
	{
		public static RoamingAround Get()			{ return new RoamingAround(); }

		public float curTime;
		public float roamingDist;

		public void Enter( MonsterStateCtrl stateCtrl, Monster mob )
		{
			Debug.Log( "Enter the RoamingAround" );

			curTime			= mob.Factor.roamingResetTime;
			roamingDist		= mob.Factor.roamingMaxDist; 
		}

		public void Update( MonsterStateCtrl stateCtrl, Monster mob )
		{
			if( null != mob.AggroTarget )
			{
				stateCtrl.ChangeBehavior( ChasingTarget.Get() );
				return;
			}

			var dir		= RandDir( mob );
			var pos		= mob.transform.position;
			pos			= pos + ( dir * mob.Factor.moveSpeed * Time.deltaTime );
			mob.transform.position = pos;
		}

		public void Exit( MonsterStateCtrl stateCtrl, Monster mob )
		{
			Debug.Log( "Exit the RoamingAround" );
		}

		private Vector3 RandDir( Monster mob )
		{
			curTime += Time.deltaTime;

			if( curTime >= mob.Factor.roamingResetTime || roamingDist >= mob.Factor.roamingMaxDist  )
			{
				curTime							= 0f;
				roamingDist						= 0f;
				var randQuat					= Quaternion.AngleAxis( Random.Range(0f, 360f), Vector3.up  );
				mob.transform.forward	= randQuat * mob.transform.forward;
			}

			return mob.transform.forward;
		}
	}
}
