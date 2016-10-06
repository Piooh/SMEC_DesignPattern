using UnityEngine;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class RoamingAround : IMonsterAI
	{
		public float curTime;
		public float roamingDist;

		public void Enter( Monster mob )
		{
			curTime			= mob.roamingResetTime;
			roamingDist		= mob.roamingMaxDist; 
		}

		public void Update( Monster mob )
		{
			var dir		= RandDir( mob );
			var pos		= mob.transform.position;
			pos			= pos + ( dir * mob.moveSpeed * Time.deltaTime );
			mob.transform.position = pos;
		}

		public void Exit( Monster mob )
		{
		}

		private Vector3 RandDir( Monster mob )
		{
			curTime += Time.deltaTime;

			if( curTime >= mob.roamingResetTime || roamingDist >= mob.roamingMaxDist  )
			{
				curTime							= 0f;
				var randQuat					= Quaternion.AngleAxis( Random.Range(0f, 360f), Vector3.up  );
				mob.transform.forward	= randQuat * mob.transform.forward;
			}

			return mob.transform.forward;
		}
	}
}
