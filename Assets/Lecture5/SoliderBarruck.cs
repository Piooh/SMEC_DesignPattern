using UnityEngine;

namespace Assets.Lecture5
{
	public class SoliderBarruck : Barrucks
	{
		protected override ICharacter Create( string type  )
		{
			ICharacter character = null;
			if ( true == string.Equals(type, "SWORD") )
			{
				character			= new SwordMan();
			}
			else if ( true == string.Equals(type, "WITCH") )
			{
				character = new Witch();
			}

			return character;
		}
	}
}
