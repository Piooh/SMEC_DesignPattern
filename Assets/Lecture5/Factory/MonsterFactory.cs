using UnityEngine;
using Assets.Lecture3.ReadOnlys;

namespace Assets.Lecture5
{
	public class MonsterFactory : CharacterFactory
	{
		protected override ICharacter Create( CharacterType type )
		{
			Monster monster		= null;
			IFXFactory fxFactory		= new MonsterFXMaker();

			if( CharacterType.Dragon == type )
			{
				var prefab          = Resources.Load<GameObject>( "Prefab/Monster/Dragon" );
				Debug.Assert(null != prefab);
				var go				 = GameObject.Instantiate( prefab ) as GameObject;
				Debug.Assert(null != go);

				monster				= go.AddComponent<Dragon>();
			}
			else if( CharacterType.Slime == type )
			{
				var prefab          = Resources.Load<GameObject>( "Prefab/Monster/Slime" );
				Debug.Assert(null != prefab);
				var go				 = GameObject.Instantiate( prefab ) as GameObject;
				Debug.Assert(null != go);

				monster				=go.AddComponent<Slime>();
			}

			if( null != monster )
			{
				monster.SetupFactor();
				monster.RegisterFX( fxFactory );
			}

			return monster;
		}
	}
}
