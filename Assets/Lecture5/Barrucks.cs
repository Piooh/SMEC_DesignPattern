using UnityEngine;
using System.Collections;

using Assets.Lecture4;

namespace Assets.Lecture5
{
	public abstract class Barrucks : GenericMonoSingleton<Barrucks>
	{
		private void Awake()
		{
			Get( "SWORD" );
			//Get( "WITCH" );
		}

		public ICharacter Get( string type )
		{
			ICharacter character = Create(type);//SimpleFactory.Create( type );

			character.LoadPrefab();

			return character;
		}

		protected abstract ICharacter Create( string type );
	}
}