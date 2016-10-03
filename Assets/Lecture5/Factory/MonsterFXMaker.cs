using UnityEngine;

namespace Assets.Lecture5
{
	public class MonsterFXMaker : IFXFactory
	{
		public FXSpell CreateSpell()
		{
			var prefab		= Resources.Load<GameObject>("FX/Particle Ribbon/Prefabs/Liberate_01");
			Debug.Assert( null != prefab );
			var go			= GameObject.Instantiate<GameObject>( prefab );
			Debug.Assert( null != prefab );

			var spell		= go.AddComponent<FXSpell>();

			return spell;
		}

		public FXMagic CreateMagic()
		{
			var prefab		= Resources.Load<GameObject>("FX/Particle Ribbon/Prefabs/Liberate_02.1");
			Debug.Assert( null != prefab );
			var go			= GameObject.Instantiate<GameObject>( prefab );
			Debug.Assert( null != prefab );

			var magic		= go.AddComponent<FXMagic>();

			return magic;
		}

		public FXAura CreateAura()
		{
			var prefab		= Resources.Load<GameObject>("FX/Particle Ribbon/Prefabs/Liberate_03 Megido");
			Debug.Assert( null != prefab );
			var go			= GameObject.Instantiate<GameObject>( prefab );
			Debug.Assert( null != prefab );

			var aura		= go.AddComponent<FXAura>();

			return aura;
		}
	}
}
