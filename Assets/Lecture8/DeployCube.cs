using UnityEngine;
using System.Collections;

namespace Assets.Lecture8
{
	public class DeployCube : MonoBehaviour
	{
		public float mapSize					= 10f;
		public int cubCount						= 10;
		public Transform holder			= null;

		private GameObject cubePrefab	= null;

		private void Awake()
		{
			Deploy();
		}

		public void Deploy()
		{
			if( null == cubePrefab )	{ cubePrefab = Resources.Load<GameObject>( "Prefab/ETC/Cube" ); }

			Vector3 pos = Vector3.zero;
			for( int i = 0; i < cubCount; i++  )
			{
				pos			= new Vector3( Random.Range(-mapSize, mapSize), 1f, Random.Range( -mapSize, mapSize) );
				var go		= Instantiate( cubePrefab, pos, Quaternion.identity, holder ) as GameObject;
				
				go.name  = string.Format( "Wall_{0:000}", i );
			}
		}
	}
}
