using UnityEngine;
using System.Collections;

namespace Assets.Lecture5
{
	public class Lecture5Temp : MonoBehaviour
	{

		public ICharacter Get( string type )
		{
			ICharacter character = null;

			if( "SwordMan" == type )					{ character = new SwordMan(); }
			else if( "Magician" == type )				{ character = new Magician(); }
			else if( "Archer" == type )					{ character = new Archer(); }
			else if( "Rabbit" == type )					{ character = new Rabbit(); }
			else if( "Slime" == type )					{ character = new Slime(); }
			else if( "Dragon" == type )				{ character = new Dragon(); }
	
			// NPC 도 추가 된다고 한다면????

			character.Init();

			return character;
		}












		public void Temp()
		{
		
		}

	}
}