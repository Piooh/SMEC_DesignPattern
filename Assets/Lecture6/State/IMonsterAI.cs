using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public interface IMonsterAI
	{
		void Enter( Monster mob );
		void Update( Monster mob );
		void Exit( Monster mob );
	}
}
