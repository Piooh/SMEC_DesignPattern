using Assets.Lecture3.ReadOnlys;

namespace Assets.Lecture5
{
	public abstract class CharacterFactory
	{
		public ICharacter Get(  CharacterType type )
		{
			ICharacter character = Create(type);//SimpleFactory.Create( type );

			character.SetRespawn();

			return character;
		}

		protected abstract ICharacter Create( CharacterType type );
	}
}
