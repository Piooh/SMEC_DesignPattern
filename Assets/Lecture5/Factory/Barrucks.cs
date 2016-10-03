using UnityEngine;
using System.Collections;

using Assets.Lecture3.ReadOnlys;
using Assets.Lecture4;

namespace Assets.Lecture5
{
	public class Barrucks : GenericMonoSingleton<Barrucks>
	{
		private CharacterFactory characterFactory	= new SoliderFactory();
		private CharacterFactory monsterFactory		= new MonsterFactory(); 

		
		public ICharacter GetSolder( CharacterType type )			{ return characterFactory.Get( type ); }
		public ICharacter GetMonster( CharacterType type )			{ return monsterFactory.Get( type ); }
	}
}