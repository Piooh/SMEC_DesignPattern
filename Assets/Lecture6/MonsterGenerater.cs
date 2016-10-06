using UnityEngine;
using System.Collections;

using Assets.Lecture5;

namespace Assets.Lecture6
{
	public class MonsterGenerater : MonoBehaviour
	{
		private void Awake()
		{
			var target							= Barrucks.Instance.GetSolder( Lecture3.ReadOnlys.CharacterType.SwordMan ) as SwordMan;
			target.transform.position	= Vector3.right * 15f;

			var slime				= Barrucks.Instance.GetMonster( Lecture3.ReadOnlys.CharacterType.Slime ) as Slime;
			var aiController	= slime.gameObject.GetComponent<SlimeAICtrl>();
			if( null  == aiController )
			{
				aiController		= slime.gameObject.AddComponent<SlimeAICtrl>();
			}
		}
	}
}
