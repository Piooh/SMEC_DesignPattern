using UnityEngine;

namespace Assets.Lecture4
{
	public class NormalMonoSingleton : MonoBehaviour
	{
		private static NormalMonoSingleton instance = null;

		public static NormalMonoSingleton GetSingleton()
		{
			if( null == instance )
			{
				instance = GameObject.FindObjectOfType<NormalMonoSingleton>();
			}

			return instance;
		}
	}
}
