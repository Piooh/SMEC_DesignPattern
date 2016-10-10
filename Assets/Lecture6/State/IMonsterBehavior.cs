using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public interface IMonsterBehavior
	{
		void Enter( MonsterStateCtrl stateCtrl, Monster mob );
		void Update( MonsterStateCtrl stateCtrl, Monster mob );
		void Exit( MonsterStateCtrl stateCtrl, Monster mob );
	}
}
