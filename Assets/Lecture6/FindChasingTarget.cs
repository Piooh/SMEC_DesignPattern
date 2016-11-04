using UnityEngine;
using System.Collections;

using Assets.Lecture3.ReadOnlys;
using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class FindChasingTarget : MonoBehaviour
	{
		private float maxChasingDist	= 10f;
		private float rangeRadius			= 10f;

		public float RangeRadius
		{
			get { return rangeRadius; }
			set { rangeRadius = value; }
		}

		public float MaxChasingDist
		{
			get { return maxChasingDist; }
			set { maxChasingDist = value; }
		}

		public Transform Target
		{
			get { return null == Mob ? null : Mob.AggroTarget; }
			private set { if ( null != Mob ) { Mob.AggroTarget = value; } }
		}

		private Monster Mob			{ get;	set; }

		private void Awake()
		{
			Mob					= GetComponent<Monster>();
			Target				= null;
			RangeRadius	= Mob.Factor.searchRadius;
		}

		private IEnumerator Start()
		{
			while( true )
			{
				yield return StartCoroutine( Search() );

				yield return StartCoroutine( CalcTargetDist() );
			}
		}

		private IEnumerator Search()
		{
			while ( null == Target )
			{
				var colTargets= Physics.OverlapSphere( transform.position, rangeRadius, 1 << ConstLayers.Soilder, QueryTriggerInteraction.Collide );

				if( null != colTargets )
				{
					float minDist		= float.MaxValue;
					int targetIndex		= -1;
					for( int i = 0; i < colTargets.Length; i++)
					{
						Vector3 dist = colTargets[i].transform.position - transform.position;
						dist.y			= 0f;

						if( dist.sqrMagnitude < minDist )
						{
							targetIndex	= i;
							minDist			= dist.sqrMagnitude; 
						}
					}

					if( 0 <= targetIndex )		{ Target = colTargets[targetIndex].transform; }
				}

				yield return new WaitForSeconds(1f);
			}
		}

		private IEnumerator CalcTargetDist()
		{
			while( null != Target )
			{
				var dist = Target.position - transform.position;

				if( dist.sqrMagnitude >= maxChasingDist  )
				{
					Target = null;
				}

				yield return null;
			}
		}
	}
}
