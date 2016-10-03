using UnityEngine;
using Assets.Lecture3;

namespace Assets.Lecture5
{
	public class SimpleFactory
	{
		public static ICharacter Create( string type )
		{
			ICharacter character = null;
			if ( true == string.Equals(type, "SWORD") )
			{
				character			= new SwordMan();
			}
			else if ( true == string.Equals(type, "WITCH") )
			{
				character			= new Witch();
			}

			return character;
		}
	}
}
