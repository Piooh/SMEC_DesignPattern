using UnityEngine;

namespace Assets.Lecture5
{
	public class SoliderFXMaker : IFXFactory
	{
		public FXSpell CreateSpell()
		{
			var prefab		= Resources.Load<GameObject>("FX/Particle Ribbon/Prefabs/Charge_01");
			Debug.Assert( null != prefab );
			var go			= GameObject.Instantiate<GameObject>( prefab );
			Debug.Assert( null != prefab );

			var spell		= go.AddComponent<FXSpell>();

			return spell;
		}

		public FXMagic CreateMagic()
		{
			var prefab		= Resources.Load<GameObject>("FX/Particle Ribbon/Prefabs/Charge_02");
			Debug.Assert( null != prefab );
			var go			= GameObject.Instantiate<GameObject>( prefab );
			Debug.Assert( null != prefab );

			var magic		= go.AddComponent<FXMagic>();

			return magic;
		}

		public FXAura CreateAura()
		{
			var prefab		= Resources.Load<GameObject>("FX/Particle Ribbon/Prefabs/Charge_03");
			Debug.Assert( null != prefab );
			var go			= GameObject.Instantiate<GameObject>( prefab );
			Debug.Assert( null != prefab );

			var aura			= go.AddComponent<FXAura>();

			return aura;
		}
	}
}
