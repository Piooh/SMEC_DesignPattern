using UnityEngine;
using System.Collections;


namespace Assets.Lecture5
{
	public class OtherObject : MonoBehaviour
	{
		private void Awake()
		{
			// solider
			Barrucks.Instance.GetSolder( Lecture3.ReadOnlys.CharacterType.SwordMan );
			Barrucks.Instance.GetSolder( Lecture3.ReadOnlys.CharacterType.Witch );

			// monster
			Barrucks.Instance.GetMonster( Lecture3.ReadOnlys.CharacterType.Dragon );
			Barrucks.Instance.GetMonster( Lecture3.ReadOnlys.CharacterType.Slime );
		}
	}
}
