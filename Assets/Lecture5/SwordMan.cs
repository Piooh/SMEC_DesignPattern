using UnityEngine;

using Assets.Lecture3;

namespace Assets.Lecture5
{
	public class SwordMan : ISolider
	{
		public string Name { get; set; }

		public void LoadPrefab()
		{
			var prefab          = Resources.Load<GameObject>( "Prefab/SwordMan" );
			Debug.Assert(null != prefab);
			var go              = GameObject.Instantiate( prefab ) as GameObject;
			Debug.Assert(null != go);
		}
	}
}
