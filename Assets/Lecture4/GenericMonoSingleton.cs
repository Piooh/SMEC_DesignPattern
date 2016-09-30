using UnityEngine;

namespace Assets.Lecture4
{
	public class GenericMonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static T instance = null;
		public static T Instance
		{
			get
			{
				if( null == instance )
				{
					instance		= GameObject.FindObjectOfType<T>();
					if( null == instance )
					{
						var go		= new GameObject( typeof(T).ToString() + "_Singleton" );
						instance	= go.AddComponent<T>();
						DontDestroyOnLoad( go );
					}
				}

				return instance;
			}
		}

		public static bool IsNull { get { return null == instance; } }

		private void Awake()
		{
			if( null != instance )
			{
				Destroy(this);
			}
			else
			{
				instance = this as T;
				DontDestroyOnLoad(gameObject);

				DoAwake();
			}
		}

		protected virtual void DoAwake()
		{

		}
	}
}

