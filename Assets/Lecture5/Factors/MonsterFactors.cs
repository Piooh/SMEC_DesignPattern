using System;
using UnityEngine;

namespace Assets.Lecture5
{
	[Serializable]
	public class MonsterFactors : CharacterFactors
	{
		public readonly float roamingResetTime			= 3f;
		public readonly float roamingMaxDist				= 10f;
		public readonly float searchRadius					= 13f;
		public readonly float moveSpeed					= 2f;	
		public readonly float attackReach					= 3f;
		public readonly float attackSpeed					= 1.5f;
	}
}
