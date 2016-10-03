using UnityEngine;

using Assets.Lecture3.ReadOnlys;
using Assets.Lecture4;

namespace Assets.Lecture5
{
	public class SoliderFactory : CharacterFactory
	{
		protected override ICharacter Create( CharacterType  type  )
		{
			ICharacter character		= null;
			IFXFactory fxMaker			= new SoliderFXMaker();

			if ( CharacterType.SwordMan == type )
			{ 
				var prefab					= Resources.Load<GameObject>( "Prefab/Character/SwordMan" );
				Debug.Assert(null != prefab);
				var go						= GameObject.Instantiate( prefab ) as GameObject;
				Debug.Assert(null != go);

				character					= go.AddComponent<SwordMan>();
			}
			else if ( CharacterType.Witch == type )
			{
				var prefab					= Resources.Load<GameObject>( "Prefab/Character/Witch" );
				Debug.Assert(null != prefab);
				var go						= GameObject.Instantiate( prefab ) as GameObject;
				Debug.Assert(null != go);

				character					= go.AddComponent<Witch>();
			}

			character.RegisterFX( fxMaker );

			return character;
		}
	}
}
